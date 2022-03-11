using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Resistella.Core.Domain;
using Resistella.Core.Infrastructures.Data.TypeConfiguration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Infrastructures.Data
{
    public class ResistellaContext : IdentityDbContext
    {
        #region Constructor
        public ResistellaContext([NotNullAttribute] DbContextOptions options) : base(options) { }
        public ResistellaContext() : base() { }
        #endregion
        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.ApplyConfiguration(new ArticleEntityTypeConfiguration());
            modelbuilder.ApplyConfiguration(new CollectionObjectEntityTypeConfiguration());
            modelbuilder.ApplyConfiguration(new TagEntityTypeConfiguration());
            modelbuilder.ApplyConfiguration(new PictureEntityTypeConfiguration());
        }
        #endregion
        #region properties
        public DbSet<Article> Articles { get; set; }
        public DbSet<CollectionObject> CollectionObjects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        #endregion
    }
}
