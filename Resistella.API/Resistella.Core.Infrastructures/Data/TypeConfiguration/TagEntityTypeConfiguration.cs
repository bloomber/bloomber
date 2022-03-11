using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resistella.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Infrastructures.Data.TypeConfiguration
{
    public class TagEntityTypeConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag")
                .HasKey(item => item.Id);


            //builder.HasMany(item => item.Articles)
            //    .WithMany(item => item.Tags)
            //    .UsingEntity(j => j.ToTable("ArticleTag"));


            builder.Property(item => item.Id).ValueGeneratedOnAdd();
        }
    }
}
