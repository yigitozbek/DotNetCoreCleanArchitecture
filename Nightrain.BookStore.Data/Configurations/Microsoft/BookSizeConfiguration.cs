using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class BookSizeConfiguration : IEntityTypeConfiguration<BookSize>
    {
        public void Configure(EntityTypeBuilder<BookSize> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Size)
                .HasColumnType("nvarchar(150)")
                .IsRequired();
        }
    }
}