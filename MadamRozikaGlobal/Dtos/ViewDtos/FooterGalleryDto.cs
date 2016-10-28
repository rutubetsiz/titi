using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MadamRozikaGlobal.Dtos.ViewDtos
{
    public class FooterGalleryDto
    {
        public int GalleryId { get; set; }
        public string Title { get; set; }
        public string SeoTitleUrl { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public CategoryMenuDto CategoryMenu { get; set; }
    }
}
