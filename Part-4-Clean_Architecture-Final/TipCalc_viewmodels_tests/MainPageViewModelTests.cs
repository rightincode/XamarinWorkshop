using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TipCalc.ViewModels;
using TipCalc_core.Models;

namespace TipCalc_viewmodels_tests
{
    [TestClass]
    public class MainPageViewModelTests
    {
        [TestMethod]
        public void CalcTip_18PercentTip100Total_GrandTotal118()
        {
            var mainPageViewModel = new MainPageViewModel(new TipCalculator());

            mainPageViewModel.TotalTxt = "100";
            mainPageViewModel.TipPercent = 18;

            Assert.AreEqual("118.00", mainPageViewModel.GrandTotalTxt);       

        }
    }
}
