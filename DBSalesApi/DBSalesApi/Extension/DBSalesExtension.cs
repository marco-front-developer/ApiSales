using DBSales.Entity;
using DBSales.Repository;

namespace DBSales.Api.Extension {
  public static class DBSalesExtension {

    public static IServiceCollection AddInjection(this IServiceCollection services) {
      //Add dependencies
      services.AddTransient<ICustomersRepository, CustomersRepository>();
      services.AddTransient<IEmployeesRepository, EmployeesRepository>();
      services.AddTransient<IProductsRepository, ProductsRepository>();
      services.AddTransient<ISalesRepository, SalesRepository>();

      return services;
    }

    public static WebApplication AddOperation(this WebApplication app) {

      #region "Sales"
      app.MapGet("/sales/get", async (ISalesRepository salesRepository, int id) => {
        var result = await salesRepository.Get(id);
        return Results.Ok(result);
      });

      app.MapGet("/sales/list", async (ISalesRepository salesRepository) => {
        var result = await salesRepository.List();
        return Results.Ok(result);
      });

      app.MapPost("/sales/add", async (ISalesRepository salesRepository, Sales sales) => {
        var result = await salesRepository.Add(sales);
        return Results.Ok(result);
      });

      app.MapPut("/sales/update", async (ISalesRepository salesRepository, Sales sales) => {
        var result = await salesRepository.Update(sales);
        return Results.Ok(result);
      });

      app.MapDelete("/sales/delete", async (ISalesRepository salesRepository, int id) => {
        var result = await salesRepository.Delete(id);
        return Results.Ok(result);
      });
      #endregion

      return app;
    }

  }
}
