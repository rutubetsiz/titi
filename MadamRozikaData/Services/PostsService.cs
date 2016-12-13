using System; 
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
 
using MadamRozikaData.Functions;
using MadamRozikaGlobal.Dtos.ViewDtos;
using MadamRozikaGlobal.Dtos.ViewDtos.SubContents;

namespace MadamRozikaData.Services
{
    public class PostsService : IDisposable
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

        public PostContentDto GetPostContentDto(int nid)
        {
            var result =
                _db.News.Include(i => i.CategoryNewsRelations.Select(c => c.Category))
                    .FirstOrDefault(p => p.Status == 1 && p.NewsId == nid);
            var subs =
                _db.News.Where(p => p.Status == 1)
                    .OrderByDescending(p => p.PublishDate).Include(i => i.CategoryNewsRelations.Select(c => c.Category))
                    .Take(5);

            if (result == null)
            { 
                result = new News();
            }
            
            var retList = new PostContentDto();
            var cn = result.CategoryNewsRelations.FirstOrDefault();
            if (cn == null)
            {
                cn = new CategoryNewsRelation()
                {
                     Category = new Category() {Name = string.Empty, CategoryId = 0} 
                };
            }

            retList.Post = new SubContent();
            retList.Post.Category = cn.Category.Name;
            retList.Post.NewsId = result.NewsId;
            retList.Post.Title = result.Title;
            retList.Post.Summary = result.Summary;
            retList.Post.ModifiedDate = result.ModifiedDate;
            retList.Post.SeoTitleUrl = result.SeoTitleUrl;
            retList.Post.Author = "Author Name";
            retList.Post.ImageUrl = !string.IsNullOrEmpty(result.ImageUrl)? result.ImageUrl.Replace("330x242", "100x100"):string.Empty;

            retList.Latests = new Mapper().MapTo(subs);
            retList.TopPostses = new Mapper().MapTo(subs);
            retList.Recommendeds = new Mapper().MapTo(subs);
            retList.TopAuthorses = new Mapper().MapTo(subs);
            retList.MostCommenteds = new Mapper().MapTo(subs);
            retList.MostReads = new Mapper().MapTo(subs);
            retList.MostRecents = new Mapper().MapTo(subs);
            retList.LatestByCategory = new List<SubContent>();


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

        ~PostsService()
        {
            Dispose(false);
        }
    }
}