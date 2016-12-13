using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadamRozikaGlobal.Dtos.ViewDtos.SubContents
{
    public class SubContent
    {
        public SubContent()
        {
            _commentCount = new Random().Next();
        }

        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string SeoTitleUrl { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

        private int _commentCount;

        public int? CommentCount
        {
            get { return _commentCount; }
            set { _commentCount = value ?? 0; }
        }
    }
}
