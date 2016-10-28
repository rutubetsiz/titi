using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadamRozikaGlobal.Dtos.ViewDtos
{
    public class HeaderMenuDto
    {
        public CategoryMenuDto CategoryMenuDto { get; set; }
        public List<NewsMenuDto> NewsMenuDto { get; set; }
    }
}
