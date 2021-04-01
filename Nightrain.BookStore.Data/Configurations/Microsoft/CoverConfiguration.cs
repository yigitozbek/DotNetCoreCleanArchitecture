using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class CoverConfiguration : IEntityTypeConfiguration<Cover>
    {
        public void Configure(EntityTypeBuilder<Cover> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Path)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder.Property(i => i.FileName)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder.Property(i => i.Queue)
                .HasColumnType("smallint")
                .IsRequired();

            builder.HasOne(i => i.Book)
                .WithOne()
                .HasForeignKey<Cover>(i => i.Id);
        }
    }
} 