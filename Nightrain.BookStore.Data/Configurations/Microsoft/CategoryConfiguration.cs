using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ParentId)
                .HasColumnType("int");

            builder.Property(i => i.Name)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder
                .HasOne(i => i.Parent);
        }
    }
}