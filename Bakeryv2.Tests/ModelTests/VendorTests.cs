using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakeryv2.Models;
using System;

namespace Bakeryv2.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
    string vendorName = "test";
    Vendor newVendor = new Vendor(vendorName);
    string result = newVendor.VendorName;
    Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string vendorName = "test2";
      Vendor newVendor = new Vendor(vendorName);

      string updatedVendorName = "test3";
      newVendor.VendorName = updatedVendorName;
      string result = newVendor.VendorName;
      Assert.AreEqual(updatedVendorName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      string vendorName01 = "test";
      string vendorName02 = "test2";
      Vendor newVendor1 = new Vendor(vendorName01);
      Vendor newVendor2 = new Vendor(vendorName02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string vendorName = "test";
      Vendor newVendor = new Vendor(vendorName);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName01 = "test";
      string vendorName02 = "test1";
      Vendor newVendor1 = new Vendor(vendorName01);
      Vendor newVendor2 = new Vendor(vendorName02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

  }
}