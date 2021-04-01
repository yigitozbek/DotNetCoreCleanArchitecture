using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Title)
                .HasColumnType("nvarchar(300)")
                .IsRequired();

            builder.Property(i => i.Description)
                .HasColumnType("nvarchar(MAX)")
                .IsRequired();

            builder.Property(i => i.Price)
                .HasColumnType("decimal(18,6)")
                .IsRequired();

            builder.Property(i => i.PrintLength)
                .HasColumnType("smallint")
                .IsRequired();

            builder.Property(i => i.Publication)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(i => i.BookSizeId)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(i => i.BookFormatId)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(i => i.PublisherId)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(i => i.LanguageId)
                .HasColumnType("int")
                .IsRequired();

            builder
                .HasOne(i => i.Language)
                .WithOne()
                .HasForeignKey<Language>(i => i.Id);

            builder
                .HasOne(i => i.Publisher)
                .WithOne()
                .HasForeignKey<Publisher>(i => i.Id);

            builder
                .HasOne(i => i.BookSize)
                .WithOne()
                .HasForeignKey<BookSize>(i => i.Id);

            builder
                .HasOne(i => i.BookFormat)
                .WithOne()
                .HasForeignKey<BookFormat>(i => i.Id);

        }
    }
}