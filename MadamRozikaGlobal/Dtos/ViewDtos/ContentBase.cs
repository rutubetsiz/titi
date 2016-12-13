using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadamRozikaGlobal.Dtos.ViewDtos.SubContents;

namespace MadamRozikaGlobal.Dtos.ViewDtos
{
    public class ContentBase
    {
        public ContentBase()
        {
            
        }

        public SubContent Post { get; set; }

        public virtual List<SubContent> Latests { get; set; }
        public virtual List<SubContent> Recommendeds { set; get; }
        public virtual List<SubContent> TopAuthorses { set; get; }
        public virtual List<SubContent> TopPostses { set; get; }
        public virtual List<SubContent> MostReads { set; get; }
        public virtual List<SubContent> MostRecents { set; get; }
        public virtual List<SubContent> MostCommenteds { set; get; }
        public virtual List<SubContent> LatestByCategory { set; get; }

    }
}
