using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfUnitTesting2ndEd.Exercises;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    public class MemCalculatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            var calc = MakeCalc();

            var lastSum = calc.Sum();

            Assert.AreEqual(0, lastSum);
        }

        private static MemCalculator MakeCalc()
        {
            return new MemCalculator();   
        }
    }
}
