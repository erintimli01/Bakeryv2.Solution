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
  }
}