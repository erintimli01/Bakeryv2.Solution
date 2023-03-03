using System.Collections.Generic;

namespace Bakeryv2.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; }
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int SearchId)
    {
      return _instances[SearchId-1];
    }
  }
}