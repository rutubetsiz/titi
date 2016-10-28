using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Functions
{
    public partial class Mapper
    {
        public NewsMenuDto MapTo(News entiy)
        {
            if (entiy == null)
                return null;

            return new NewsMenuDto
            {
                ImageUrl = entiy.ImageUrl.Replace("330x242", "100x100"),
                Title = entiy.Title,
                ModifiedDate = entiy.ModifiedDate,
                SeoTitleUrl = entiy.SeoTitleUrl,
                NewsId = entiy.NewsId
            };
        }
    }
}
