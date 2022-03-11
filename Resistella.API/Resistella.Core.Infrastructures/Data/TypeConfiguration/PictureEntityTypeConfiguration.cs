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
    class PictureEntityTypeConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.ToTable("Picture")
                .HasKey(picture => picture.Id);


            builder.HasOne(picture => picture.Article)
            .WithMany(article => article.Pictures)
            .HasForeignKey(picture => picture.Id_Article)
            .HasPrincipalKey(article => article.Id)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Property(item => item.Id).ValueGeneratedOnAdd();
        }
    }
}
