using DBSales.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository.Context.Configuration {
  internal class ProductsConfiguration : IEntityTypeConfiguration<Products> {
    public void Configure(EntityTypeBuilder<Products> builder) {
      //builder.ToTable("Products");
      builder.HasKey(x => x.Id);
      builder.HasKey("Id");
      builder.Property(x => x.Id).HasColumnName("Id");
      builder.Property(x => x.Name).HasColumnName("Name");
      builder.Property(x => x.Price).HasColumnName("Price");
    }
  }
}
