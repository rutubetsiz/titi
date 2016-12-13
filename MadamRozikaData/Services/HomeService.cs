using System; 
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MadamRozikaData.Functions;
using MadamRozikaGlobal.Dtos.ViewDtos;
using MadamRozikaGlobal.Dtos.ViewDtos.SubContents;

namespace MadamRozikaData.Services
{
    public class HomeService : IDisposable
    {
        private readonly MadamRozikaEntities _db = new MadamRozikaEntities();
        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public List<SubContent> GetLatestContentByCategory(int cat)
        {
            var result =
                _db.News
                    .Include(cu => cu.CategoryNewsRelations)
                    .Include(ct => ct.CategoryNewsRelations.Select(co => co.Category))
                    .Where(w => w.Status == 1 && w.CategoryNewsRelations.Any(x=> x.CategoryId == cat))
                    .Select(s => new SubContent
                    {
                        ImageUrl = s.ImageUrl,
                        ModifiedDate = s.ModifiedDate,
                        Category = s.CategoryNewsRelations.FirstOrDefault().Category.Name,
                        NewsId = s.NewsId,
                        SeoTitleUrl = s.SeoTitleUrl,
                        Summary = s.Summary,
                        Title = s.Title
                    }).ToList();
            
            return new Mapper().MapTo(result);
        }

        public MainContentDto GetMainContent()
        {
            var result =
                _db.News.Where(p => p.Status == 1)
                    .OrderByDescending(p => p.PublishDate).Include(i => i.CategoryNewsRelations.Select(c => c.Category))
                    .Take(5);

           

            var retList = new MainContentDto
            {
                Latests = new Mapper().MapTo(result),
                TopPostses = new Mapper().MapTo(result),
                Recommendeds = new Mapper().MapTo(result),
                TopAuthorses = new Mapper().MapTo(result),
                MostCommenteds = new Mapper().MapTo(result),
                MostReads = new Mapper().MapTo(result),
                MostRecents = new Mapper().MapTo(result),
                LatestByCategory = new List<SubContent>()
            };

            retList.LatestByCategory.AddRange(GetLatestContentByCategory(1));
            retList.LatestByCategory.AddRange(GetLatestContentByCategory(2));
            retList.LatestByCategory.AddRange(GetLatestContentByCategory(3));
            retList.LatestByCategory.AddRange(GetLatestContentByCategory(4));
            return retList;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _disposed = true;
                }
            }
        }

        ~HomeService()
        {
            Dispose(false);
        }
    }
}