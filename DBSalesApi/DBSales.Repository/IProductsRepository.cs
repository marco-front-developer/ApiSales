using DBSales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public interface IProductsRepository {
    Task<Products> Get(int id);
    Task<List<Products>> List();
    Task<Products> Delete(int id);
    Task<Products> Add(Products products);
    Task<Products> Update(Products products);
  }
}
