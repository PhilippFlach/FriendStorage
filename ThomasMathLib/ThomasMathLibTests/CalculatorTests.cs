using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThomasMathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasMathLib.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddShouldReturnSumOfValues()
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}