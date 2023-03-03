using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakeryv2.Models;
using System.Collections.Generic;
using System;

namespace Bakeryv2.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test order";
      Order newOrder = new Order(name);
      string result = newOrder.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string name = "test order";
      Order newOrder = new Order(name);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string name01 = "Test1";
      string name02 = "Test2";
      Order newOrder1 = new Order(name01);
      Order newOrder2 = new Order(name02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}