using System.Collections.Generic;

namespace Bakeryv2.Models
{
  public class Order
  {
    public string Name { get; set; }

    public Order(string orderName)
    {
      Name = orderName;
    }
  }
}