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
    
    public partial class CommentAuthorRelation
    {
        public int CommentAuthorId { get; set; }
        public Nullable<int> CommentId { get; set; }
        public Nullable<int> AuthorId { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
