using DBSales.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository.Context.Configuration {
  public class CustomersConfiguration : IEntityTypeConfiguration<Customers> {
    public void Configure(EntityTypeBuilder<Customers> builder) {
      builder.ToTable("Customers");
      builder.HasKey(x => x.Id);
      //builder.HasKey("Id");
      builder.Property(x => x.Id).HasColumnName("Id");
      builder.Property(x => x.Name).HasColumnName("Name");  

    }
  }
}
