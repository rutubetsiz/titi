using MadamRozikaGlobal.Dtos.ViewDtos;
using System.Collections.Generic;

namespace MadamRozikaData.Functions
{
   public partial class Mapper
    {
       public List<NewsMenuDto> MapTo(List<News> entity)
       {
           if (entity == null)
               return null;
           var model = new List<NewsMenuDto>();
           foreach (var item in entity)
           {
               model.Add(new NewsMenuDto
               {
                   ImageUrl = item.ImageUrl,
                   Title = item.Title,
                   ModifiedDate = item.ModifiedDate,
                   SeoTitleUrl = item.SeoTitleUrl,
                   NewsId = item.NewsId
               });
           }

           return model;
       }
    }
}
