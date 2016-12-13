using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Functions
{
    public partial class Mapper
    {
        public FooterGalleryDto MapTo(Gallery gallery, Category category)
        {
            if (gallery == null || category == null)
                return null;

            return new FooterGalleryDto
            {
                GalleryId = gallery.GalleryId,
                ModifiedDate = gallery.ModifiedDate,
                SeoTitleUrl = gallery.SeoTitleUrl,
                ImageUrl = gallery.ImageUrl,
                Title = gallery.Title,
                CategoryMenu = new Mapper().MapTo(category)
            };
        }
    }
}