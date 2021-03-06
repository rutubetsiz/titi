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
    
    public partial class Comment
    {
        public Comment()
        {
            this.CommentArticleRelations = new HashSet<CommentArticleRelation>();
            this.CommentAuthorRelations = new HashSet<CommentAuthorRelation>();
            this.CommentGalleryRelations = new HashSet<CommentGalleryRelation>();
            this.CommentNewsRelations = new HashSet<CommentNewsRelation>();
        }
    
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public string IpAddress { get; set; }
        public Nullable<int> ParentId { get; set; }
    
        public virtual ICollection<CommentArticleRelation> CommentArticleRelations { get; set; }
        public virtual ICollection<CommentAuthorRelation> CommentAuthorRelations { get; set; }
        public virtual ICollection<CommentGalleryRelation> CommentGalleryRelations { get; set; }
        public virtual ICollection<CommentNewsRelation> CommentNewsRelations { get; set; }
    }
}
