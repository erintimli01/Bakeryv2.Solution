using System.Collections.Generic;

namespace Bakeryv2.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
    }
  }
}