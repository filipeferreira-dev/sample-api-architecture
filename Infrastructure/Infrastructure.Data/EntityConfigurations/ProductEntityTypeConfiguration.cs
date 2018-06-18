using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Data.EntityConfigurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .ToTable(nameof(Product))
                .HasKey(i => i.ProductId);

            builder.HasIndex(i => i.ProductUuid);

            builder
                .Property(i => i.ProductId);

            builder
                .Property(i => i.ProductUuid)
                .IsRequired()
                .HasDefaultValueSql("newid()")
                .HasColumnType("varchar(36)");

            builder
                .Property(i => i.ExpirationDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder
                .Property(i => i.Name)
                .IsRequired()
                .HasColumnType("varchar(255)");
        }
    }
}
