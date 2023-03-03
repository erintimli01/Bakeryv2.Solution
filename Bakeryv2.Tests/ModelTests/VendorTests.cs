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
  }
}