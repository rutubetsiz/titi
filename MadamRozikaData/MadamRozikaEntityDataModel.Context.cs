﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MadamRozikaEntities : DbContext
    {
        public MadamRozikaEntities()
            : base("name=MadamRozikaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryRelation> CategoryRelations { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<GalleryItem> GalleryItems { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagRelation> TagRelations { get; set; }
    
        public virtual ObjectResult<Sp_GetNewsListWithCategoryUrl_Result> Sp_GetNewsListWithCategoryUrl(string categoryUrl)
        {
            var categoryUrlParameter = categoryUrl != null ?
                new ObjectParameter("CategoryUrl", categoryUrl) :
                new ObjectParameter("CategoryUrl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_GetNewsListWithCategoryUrl_Result>("Sp_GetNewsListWithCategoryUrl", categoryUrlParameter);
        }
    }
}