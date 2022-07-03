using DBSales.Entity;
using DBSales.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public class SalesRepository : ISalesRepository {
    private readonly DBSalesContext context;
    public SalesRepository(DBSalesContext context) {
      this.context = context;

    }
    public async Task<Sales> Add(Sales sales) {
      await context.Sales.AddAsync(sales);
      await context.SaveChangesAsync();
      return sales;
    }

    public async Task<Sales> Delete(int id) {
      Sales sales = context.Sales.FirstOrDefault(x => x.Id == id);
      var result = context.Sales.Remove(sales);
      await context.SaveChangesAsync();
      return sales;
    }

    public async Task<Sales> Get(int id) {
      //var result = await context.Sales.FirstOrDefaultAsync(x => x.Id == id);
      var result = await context.Sales.Include(x => x.Customers).Include(x => x.Employees).Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == id);
      return result;
    }

    public async Task<List<Sales>> List() {
      var result = await context.Sales.Include(x => x.Customers).Include(x => x.Employees).Include(x => x.Products).ToListAsync();
      return result;
    }

    public async Task<Sales> Update(Sales sales) {
      var result = context.Sales.Update(sales);
      await context.SaveChangesAsync();
      return sales;
    }
  }
}
