using System.Collections.Generic;
using System.Linq;
using MadamRozikaData.Functions;
using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Services
{
    public class HeaderMenuService
    {
        private readonly MadamRozikaEntities _db = new MadamRozikaEntities();

        public List<HeaderMenuDto> GetMenu()
        {
            return
                (from a in
                    _db.Categories.Where(p => p.Status == 1).OrderBy(p => p.ParentId).ThenBy(p => p.Rank).ToList()
                    select new HeaderMenuDto
                    {
                        CategoryMenuDto = new Mapper().MapTo(a),
                        NewsMenuDto =
                            new Mapper().MapTo(
                                _db.News.Where(p => p.CategoryId == a.CategoryId && p.Status == 1)
                                    .OrderByDescending(p => p.PublishDate)
                                    .Take(3)
                                    .ToList())
                    }).ToList();
        }
    }
}