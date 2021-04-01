using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.BookId)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(i => i.Book)
                .WithOne()
                .HasForeignKey<Book>(i => i.Id);

            builder.Property(i => i.CategoryId)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(i => i.Category)
                .WithOne()
                .HasForeignKey<Category>(i => i.Id);
        }
    }
}