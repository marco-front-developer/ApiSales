using DBSales.Entity;
using DBSales.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public class CustomersRepository : ICustomersRepository {
    private readonly DBSalesContext context;

    public CustomersRepository(DBSalesContext context) {
      this.context = context;

    }

    public async Task<Customers> Add(Customers customersParam) {
      await context.Customers.AddAsync(customersParam);
      await context.SaveChangesAsync();
      return customersParam;
    }

    public async Task<Customers> Delete(int id) {
      Customers customers = context.Customers.FirstOrDefault(x => x.Id == id);
      var  result = context.Customers.Remove(customers);
      await context.SaveChangesAsync();
      return customers;
    }
    
    public async Task<Customers> Get(int id) {
      var result = await context.Customers.FirstOrDefaultAsync(x => x.Id == id);
      return result;
    }

    public async Task<List<Customers>> List() {
      var result = await context.Customers.ToListAsync();
      return result;
    }


    public async Task<Customers> Update(Customers customers) {
      var result = context.Customers.Update(customers);
      await context.SaveChangesAsync();
      return customers;
    }

  }
}
