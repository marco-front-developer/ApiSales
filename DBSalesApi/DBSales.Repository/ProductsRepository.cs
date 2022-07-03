using DBSales.Entity;
using DBSales.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public class ProductsRepository : IProductsRepository {
    private readonly DBSalesContext context;

    public ProductsRepository(DBSalesContext context) {
      this.context = context;

    }
    public async Task<Products> Add(Products products) {
      await context.Products.AddAsync(products);
      await context.SaveChangesAsync();
      return products;
    }

    public async Task<Products> Delete(int id) {
      Products products = context.Products.FirstOrDefault(x => x.Id == id);
      var result = context.Products.Remove(products);
      await context.SaveChangesAsync();
      return products;
    }

    public async Task<Products> Get(int id) {
      var result = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
      return result;
    }

    public async Task<List<Products>> List() {
      var result = await context.Products.ToListAsync();
      return result;
    }

    public async Task<Products> Update(Products products) {
      var result = context.Products.Update(products);
      await context.SaveChangesAsync();
      return products;
    }
  }
}
