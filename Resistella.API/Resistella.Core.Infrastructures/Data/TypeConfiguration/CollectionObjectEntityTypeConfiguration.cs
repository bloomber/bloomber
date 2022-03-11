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
    public class CollectionObjectEntityTypeConfiguration : IEntityTypeConfiguration<CollectionObject>
    {
        public void Configure(EntityTypeBuilder<CollectionObject> builder)
        {
            builder.ToTable("CollectionObject")
                .HasKey(collectionObj => collectionObj.Id);




            builder.Property(item => item.Id).ValueGeneratedOnAdd();

        }
    }
}
