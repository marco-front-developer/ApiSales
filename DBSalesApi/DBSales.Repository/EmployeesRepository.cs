using DBSales.Entity;
using DBSales.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Repository {
  public class EmployeesRepository : IEmployeesRepository {
    private readonly DBSalesContext context;

    public EmployeesRepository(DBSalesContext context) {
      this.context = context;

    }
    public async Task<Employees> Add(Employees employees) {
      await context.Employees.AddAsync(employees);
      await context.SaveChangesAsync();
      return employees;
    }

    public async Task<Employees> Delete(int id) {
      Employees employees = context.Employees.FirstOrDefault(x => x.Id == id);
      var result = context.Employees.Remove(employees);
      await context.SaveChangesAsync();
      return employees;
    }

    public async Task<Employees> Get(int id) {
      var result = await context.Employees.FirstOrDefaultAsync(x => x.Id == id);
      return result;
    }

    public async Task<List<Employees>> List() {
      var result = await context.Employees.ToListAsync();
      return result;
    }

    public async Task<Employees> Update(Employees employees) {
      var result = context.Employees.Update(employees);
      await context.SaveChangesAsync();
      return employees;
    }
  }
}
