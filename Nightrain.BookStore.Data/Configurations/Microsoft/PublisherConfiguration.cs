using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .HasColumnType("nvarchar(80)")
                .IsRequired();
        }
    }
}