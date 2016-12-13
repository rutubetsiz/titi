using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Functions
{
    public partial class Mapper
    {
        public NewsListDto MapTo(News news, Category category)
        {
            if (news == null || category == null)
                return null;

            return new NewsListDto
            {
                Summary = news.Summary
            };
        }

        public List<NewsListDto> MapTo(ObjectResult<Sp_GetNewsListWithCategoryUrl_Result> entity)
        {
            if (entity == null)
                return null;

            var model = new List<NewsListDto>();
            foreach (var item in entity)
            {
                model.Add(new NewsListDto
                {
                    ImageUrl = item.ImageUrl,
                    Summary = item.Summary,
                    CategoryName = item.Name,
                    CategoryUrl = item.Url,
                    ModifiedDate = item.ModifiedDate,
                    NewsId = item.NewsId,
                    PublishDate = item.PublishDate,
                    SeoTitle = item.SeoTitle,
                    SeoTitleUrl = item.SeoTitleUrl,
                    Tags = item.Tags,
                    Title = item.Title,
                    TitleUrl = item.TitleUrl
                });
            }

            return model;
        }
    }
}