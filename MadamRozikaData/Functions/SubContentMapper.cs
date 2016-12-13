using System.Collections.Generic;
using System.Linq;
using MadamRozikaGlobal.Dtos.ViewDtos.SubContents;

namespace MadamRozikaData.Functions
{
    public partial class Mapper
    {
        public List<SubContent> MapTo(IEnumerable<News> entityList)
        {
            if (entityList == null)
                return null;

            var mappedList = new List<SubContent>();
            foreach (var entity in entityList)
            {
                var cn = entity.CategoryNewsRelations.FirstOrDefault();
                if (cn != null)
                    mappedList.Add(new SubContent
                    {
                        Category = cn.Category.Name,
                        NewsId = entity.NewsId,
                        Title = entity.Title,
                        Summary = entity.Summary,
                        ModifiedDate = entity.ModifiedDate,
                        SeoTitleUrl = entity.SeoTitleUrl,
                        ImageUrl = entity.ImageUrl.Replace("330x242", "100x100")
                    });
            }
            return mappedList;
        }

        public List<SubContent> MapTo(List<SubContent> entityList)
        {
            if (entityList == null)
                return null;

            var mappedList = new List<SubContent>();
            foreach (var entity in entityList)
            {

                mappedList.Add(new SubContent
                {
                    Category = entity.Category,
                    NewsId = entity.NewsId,
                    Title = entity.Title,
                    Summary = entity.Summary,
                    ModifiedDate = entity.ModifiedDate,
                    SeoTitleUrl = entity.SeoTitleUrl,
                    ImageUrl = entity.ImageUrl.Replace("330x242", "100x100")
                });


            }
            return mappedList;
        }
    }
}