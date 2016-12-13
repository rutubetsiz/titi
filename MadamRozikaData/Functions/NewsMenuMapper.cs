using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Functions
{
    public partial class Mapper
    {
        public NewsMenuDto MapTo(News entity)
        {
            if (entity == null)
                return null;

            return new NewsMenuDto
            {
                ImageUrl = entity.ImageUrl.Replace("330x242", "100x100"),
                Title = entity.Title,
                ModifiedDate = entity.ModifiedDate,
                SeoTitleUrl = entity.SeoTitleUrl,
                NewsId = entity.NewsId
            };
        }
    }
}