using MadamRozikaData.Functions;
using MadamRozikaGlobal.Dtos.ViewDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadamRozikaData.Services
{
    public class HeaderBandService
    {
        readonly MadamRozikaEntities _db = new MadamRozikaEntities();

        public List<NewsMenuDto> GetHeaderNews()
        {
            return (from news in _db.News.Where(p => p.Status == 1).OrderByDescending(p => p.PublishDate).Take(5).ToList()
                    select new Mapper().MapTo(news)).ToList();
        }
    }
}
