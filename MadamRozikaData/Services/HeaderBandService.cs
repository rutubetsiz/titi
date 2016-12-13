using System.Collections.Generic;
using System.Linq;
using MadamRozikaData.Functions;
using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Services
{
    public class HeaderBandService
    {
        private readonly MadamRozikaEntities _db = new MadamRozikaEntities();

        public List<NewsMenuDto> GetHeaderNews()
        {
            return
                (from news in _db.News.Where(p => p.Status == 1).OrderByDescending(p => p.PublishDate).Take(5).ToList()
                    select new Mapper().MapTo(news)).ToList();
        }
    }
}