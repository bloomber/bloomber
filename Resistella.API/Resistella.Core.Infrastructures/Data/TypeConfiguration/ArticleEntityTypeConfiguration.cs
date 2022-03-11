using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resistella.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Infrastructures.Data.TypeConfiguration
{
    public class ArticleEntityTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Article")
                .HasKey(article => article.Id);


            builder.HasOne(article => article.CollectionObject)
            .WithMany(collectionObj => collectionObj.Articles)
            .HasForeignKey(article => article.Id_Collection)
            .HasPrincipalKey(collectionObj => collectionObj.Id)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(item => item.Tags)
                .WithMany(item => item.Articles)
                .UsingEntity(j => j.ToTable("ArticleTag"));
                


            builder.Property(article => article.Id).ValueGeneratedOnAdd();

        }
    }
}
