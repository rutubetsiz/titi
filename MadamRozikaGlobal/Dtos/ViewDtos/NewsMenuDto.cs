using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadamRozikaGlobal.Dtos.ViewDtos
{
  public  class NewsMenuDto
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string SeoTitleUrl { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
