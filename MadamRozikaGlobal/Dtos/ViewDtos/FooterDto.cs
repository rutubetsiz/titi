using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadamRozikaGlobal.Dtos.ViewDtos
{
   public class FooterDto
    {
        public List<FooterNewsDto> FooterNewsListDto { get; set; }
        public List<FooterGalleryDto> FooterGalleryListDto { get; set; }
        public List<CategoryMenuDto> CategoryMenuListDto { get; set; }
    }
}
