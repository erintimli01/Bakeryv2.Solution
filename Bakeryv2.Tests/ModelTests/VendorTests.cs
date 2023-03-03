using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakeryv2.Models;
using System;

namespace Bakeryv2.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}