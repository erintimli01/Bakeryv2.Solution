using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace Bakeryv2.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
      {
        List<Order> allOrders = Order.GetAll();
        return View(allOrders);
      }
    
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string orderName)
    {
      Order newOrder = new Order(orderName);
      {
        return RedirectToAction("Index");
      }
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Order selectedOrder = Order.Find(id);
      List<Vendor> orderVendors = selectedOrder.Vendors;
      model.Add("order", selectedOrder);
      model.Add("vendor", selectedVendors);
      return View(model);
    }
  }
}
      // Order order = Order.Find(orderId);
      // Vendor vendor = Vendor.Find(vendorId);
    // [HttpGet("/vendors/{vendorId}/orders/new")]
    // public ActionResult New(int vendorId)
    // {
    //   Vendor vendor = Vendor.Find(vendorId);
    //   return View(vendor);
    // }