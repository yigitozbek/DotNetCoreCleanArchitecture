using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class AuthorBookConfiguration : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> builder)
        {

            builder.HasKey(i => i.Id);

            builder.Property(i => i.BookId)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(i => i.Book)
                .WithOne()
                .HasForeignKey<AuthorBook>(i => i.BookId);

            builder.Property(i => i.AuthorId)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(i => i.Author)
                .WithOne()
                .HasForeignKey<AuthorBook>(i => i.AuthorId);
            
        }
    }
}