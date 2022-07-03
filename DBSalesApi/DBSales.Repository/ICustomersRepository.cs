using DBSales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public interface ICustomersRepository {
    Task<Customers> Get(int id);
    Task<List<Customers>> List();
    Task<Customers> Delete(int id);
    Task<Customers> Add(Customers customers);
    Task<Customers> Update(Customers customers);
  }
}
