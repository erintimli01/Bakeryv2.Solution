using Microsoft.AspNetCore.Mvc;
using Bakeryv2.Models;
using System.Collections.Generic;

namespace Bakeryv2.Controllers
{
  //items=vendors category=orders
  public class VendorsController : Controller
  {
    [HttpGet("/orders/{orderId}/vendors/new")]
    public ActionResult New(int orderId)
    {
      Order order = Order.Find(orderId);
      return View(order);
    }

    [HttpGet("/orders/{orderId}/vendors/{vendorId}")]
    public ActionResult Show(int orderId, int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("order", order);
      return View(model);
    }
  }
}