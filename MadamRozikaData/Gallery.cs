//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MadamRozikaData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gallery
    {
        public int GalleryId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string TitleUrl { get; set; }
        public string SeoTitle { get; set; }
        public string SeoTitleUrl { get; set; }
        public System.DateTime PublishDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public byte Status { get; set; }
        public int ItemCount { get; set; }
        public string ImageUrl { get; set; }
        public string Tags { get; set; }
        public string FilePath { get; set; }
    }
}
