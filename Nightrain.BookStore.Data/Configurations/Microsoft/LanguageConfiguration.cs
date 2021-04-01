using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nightrain.BookStore.Domain.Entities;

namespace Nightrain.BookStore.Data.Configurations.Microsoft
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .HasColumnType("nvarchar(80)")
                .IsRequired();
        }
    }
}