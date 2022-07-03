using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSales.Entity {
  public class Sales {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    [ForeignKey("Customers")]
    public int Customer_Id { get; set; }
    [ForeignKey("Employees")]
    public int Employee_Id { get; set; }
    [ForeignKey("Products")]
    public int Product_Id { get; set; }
    public virtual Customers Customers { get; set; }
    public virtual Employees Employees { get; set; }
    public virtual Products Products { get; set; }
  }
}
