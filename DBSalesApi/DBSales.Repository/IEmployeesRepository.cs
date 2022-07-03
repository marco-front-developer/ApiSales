using DBSales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public interface IEmployeesRepository {
    Task<Employees> Get(int id);
    Task<List<Employees>> List();
    Task<Employees> Delete(int id);
    Task<Employees> Add(Employees employees);
    Task<Employees> Update(Employees employees);
  }
}
