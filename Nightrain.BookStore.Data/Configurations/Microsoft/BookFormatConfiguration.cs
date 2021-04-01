using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class BookFormatConfiguration : IEntityTypeConfiguration<BookFormat>
    {
        public void Configure(EntityTypeBuilder<BookFormat> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .HasColumnType("nvarchar(150)")
                .IsRequired();
        }
    }
}