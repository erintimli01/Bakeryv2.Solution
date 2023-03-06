using Microsoft.AspNetCore.Mvc;
using Bakeryv2.Models;
using System.Collections.Generic;
using System;

namespace Bakeryv2.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
      {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
      }
    
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      {
        return RedirectToAction("Index");
      }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id);
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
    }
  }
}

    // [HttpGet("/vendors/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Vendor selectedVendor = Vendor.Find(id);
    //   List<Order> vendorOrders = selectedVendor.Orders;
    //   model.Add("order", selectedOrder);
    //   model.Add("vendor", orderVendors);
    //   return View(model);
    // }
      // Order order = Order.Find(orderId);
      // Vendor vendor = Vendor.Find(vendorId);
    // [HttpGet("/vendors/{vendorId}/orders/new")]
    // public ActionResult New(int vendorId)
    // {
    //   Vendor vendor = Vendor.Find(vendorId);
    //   return View(vendor);
    // }