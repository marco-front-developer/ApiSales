using DBSales.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository.Context.Configuration {
  internal class SalesConfiguration : IEntityTypeConfiguration<Sales> {
    public void Configure(EntityTypeBuilder<Sales> builder) {
      builder.ToTable("Sales");
      builder.HasKey(x => x.Id);
      //builder.HasKey("Id");
      builder.Property(x => x.Id).HasColumnName("Id");
      builder.Property(x => x.Date).HasColumnName("Date");
      builder.Property(x => x.UnitPrice).HasColumnName("UnitPrice");
      builder.Property(x => x.Quantity).HasColumnName("Quantity");
      builder.Property(x => x.TotalPrice).HasColumnName("TotalPrice");
      builder.Property(x => x.Customer_Id).HasColumnName("Customer_Id");
      builder.Property(x => x.Employee_Id).HasColumnName("Employee_Id");
      builder.Property(x => x.Product_Id).HasColumnName("Product_Id");
      //Relacionamos las tablas
   
      /*builder.HasOne<Customers>(x => x.Customers).WithMany(o => o.Sales).HasForeignKey(x => x.Customer_Id);
      builder.HasOne<Employees>(x => x.Employees).WithMany(o => o.Sales).HasForeignKey(x => x.Employee_Id);
      builder.HasOne<Products>(x => x.Products).WithMany(o => o.Sales).HasForeignKey(x => x.Product_Id);
      */
    }
  }
}
