using DBSales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public interface ISalesRepository {
    Task<Sales> Get(int id);
    Task<List<Sales>> List();
    Task<Sales> Delete(int id);
    Task<Sales> Add(Sales sales);
    Task<Sales> Update(Sales sales);
  }
}
