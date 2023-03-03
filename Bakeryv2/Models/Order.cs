using System.Collections.Generic;

namespace Bakeryv2.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Vendor> Vendors { get; set; }

    public Order(string orderName)
    {
      Name = orderName;
      _instances.Add(this);
      Id = _instances.Count;
      Vendors = new List<Vendor> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}