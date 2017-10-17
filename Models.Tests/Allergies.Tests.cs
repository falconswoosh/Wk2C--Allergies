using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTest
  {
    [TestMethod]
    public void GetAllergyCode_ScoreOfZero_ReturnNothing()
    {
      CollectionAssert.AreEqual(new List<string> {}, AllergyCalc.GetAllergyCode(0));
    }
    [TestMethod]
    public void GetAllergyCode_ScoreOf1_ReturnEggs()
    {
      CollectionAssert.AreEqual(new List<string> {"eggs"}, AllergyCalc.GetAllergyCode(1));
    }
  }
}
