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
    
    public partial class Tag
    {
        public Tag()
        {
            this.TagArticleRelations = new HashSet<TagArticleRelation>();
            this.TagGalleryRelations = new HashSet<TagGalleryRelation>();
            this.TagNewsRelations = new HashSet<TagNewsRelation>();
        }
    
        public int TagId { get; set; }
        public string Tag1 { get; set; }
        public string Url { get; set; }
    
        public virtual ICollection<TagArticleRelation> TagArticleRelations { get; set; }
        public virtual ICollection<TagGalleryRelation> TagGalleryRelations { get; set; }
        public virtual ICollection<TagNewsRelation> TagNewsRelations { get; set; }
    }
}
