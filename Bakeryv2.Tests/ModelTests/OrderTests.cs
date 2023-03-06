using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakeryv2.Models;
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
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderName_ReturnsOrderName_String()
    {
    string orderName = "test";
    Order newOrder = new Order(orderName);
    string result = newOrder.OrderName;
    Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "test2";
      Order newOrder = new Order(orderName);

      string updatedOrderName = "test3";
      newOrder.OrderName = updatedOrderName;
      string result = newOrder.OrderName;
      Assert.AreEqual(updatedOrderName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string orderName01 = "test";
      string orderName02 = "test2";
      Order newOrder1 = new Order(orderName01);
      Order newOrder2 = new Order(orderName02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string orderName = "test";
      Order newOrder = new Order(orderName);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderName01 = "test";
      string OrderName02 = "test1";
      Order newOrder1 = new Order(orderName01);
      Order newOrder2 = new Order(OrderName02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

  }
}