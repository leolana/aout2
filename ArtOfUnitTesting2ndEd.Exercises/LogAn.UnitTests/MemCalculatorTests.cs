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

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            var calc = MakeCalc();

            calc.Add(1);
            var sum = calc.Sum();

            Assert.AreEqual(1, sum);
        }

        private static MemCalculator MakeCalc()
        {
            return new MemCalculator();   
        }
    }
}
