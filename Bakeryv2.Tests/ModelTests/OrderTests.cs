using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakeryv2.Models;
using System.Collections.Generic;
using System;

namespace Bakeryv2.Tests
{
  [TestClass]
  public class OrderTests
  {

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
  }
}