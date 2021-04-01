    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.Property(i => i.Surname)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.Property(i => i.Biography)
                .HasColumnType("nvarchar(MAX)");

            builder.Property(i => i.Birthday)
                .HasColumnType("date");

        }
    }
}