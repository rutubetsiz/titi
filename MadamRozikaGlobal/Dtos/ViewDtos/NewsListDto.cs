using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MadamRozikaGlobal.Dtos.ViewDtos
{
    public class NewsListDto
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string TitleUrl { get; set; }
        public string SeoTitle { get; set; }
        public string SeoTitleUrl { get; set; }
        public string Summary { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Tags { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryName { get; set; }
        public string CategoryUrl { get; set; }
    }
}