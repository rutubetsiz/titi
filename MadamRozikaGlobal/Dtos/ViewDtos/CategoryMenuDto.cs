﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadamRozikaGlobal.Dtos.ViewDtos
{
    public class CategoryMenuDto
    {
        public int CategoryId { get; set; }
        public int? ParentId { get; set; }
        public int? MegaMenu { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
