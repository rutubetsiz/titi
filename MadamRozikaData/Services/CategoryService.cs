using System.Collections.Generic;
using MadamRozikaData.Functions;
using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Services
{
    public class CategoryService
    {
        private readonly MadamRozikaEntities _db = new MadamRozikaEntities();

        public List<NewsListDto> GetNewsList(string categoryurl)
        {
            return new Mapper().MapTo(_db.Sp_GetNewsListWithCategoryUrl(categoryurl));

            //return _db.News.Where(c =>
            //    _db.CategoryRelations.Where(b =>
            //    _db.Categories.Where(a => a.ParentId == _db.Categories.Where(p => p.Url == categoryurl).Select(p => p.CategoryId).FirstOrDefault()
            //    ).Select(p => p.CategoryId).Contains((int)b.CategoryId)
            //    ).GroupBy(p => p.ContentId).Select(t => t.Key).Contains(c.NewsId)
            //    ).OrderByDescending(p => p.ModifiedDate).ToList().Select(p => new Mapper().MapTo(p, _db.Categories.FirstOrDefault(k => k.CategoryId == p.CategoryId))).ToList()
            //    ;
        }
    }
}