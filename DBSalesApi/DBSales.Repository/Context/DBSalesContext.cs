using DBSales.Entity;
using DBSales.Repository.Context.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository.Context {
  public class DBSalesContext :DbContext {
    public DBSalesContext(DbContextOptions<DBSalesContext> options) : base(options) { 
    
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      modelBuilder.ApplyConfiguration(new CustomersConfiguration());
      modelBuilder.ApplyConfiguration(new EmployeesConfiguration());
      modelBuilder.ApplyConfiguration(new ProductsConfiguration());
      modelBuilder.ApplyConfiguration(new SalesConfiguration());

      base.OnModelCreating(modelBuilder);

    }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<Employees> Employees { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Sales> Sales { get; set; }
  }
}
