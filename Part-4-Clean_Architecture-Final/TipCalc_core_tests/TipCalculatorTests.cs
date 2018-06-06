using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TipCalc_core.Models;

namespace TipCalc_core_tests
{
    [TestClass]
    public class TipCalculatorTests
    {
        [TestMethod]
        public void CalcTip_18PercentTip100Total_GrandTotal118()
        {
            var tipCalculator = new TipCalculator
            {
                Total = 100,
                TipPercent = 18
            };

            tipCalculator.CalcTip();

            Assert.AreEqual(decimal.Parse("118"), tipCalculator.GrandTotal);
        }
    }
}
