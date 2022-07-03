using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Entity {
  public class Products {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

   // public List<Sales> Sales { get; set; }
  }
}
