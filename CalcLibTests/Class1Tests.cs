using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void PlusTest()
        {
            var number = Claculator.Plus(2,2);
            Assert.AreEqual(4, number);
        }

        [TestMethod()]
        public void PlusTest1()
        {
            var number = Claculator.Plus(2.0, 2.5);
            Assert.AreEqual(4.5, number);
        }

        [TestMethod()]
        public void MinusTest()
        {
            var number = Claculator.Minus(10, 5.5);
            Assert.AreEqual(4.5, number);
        }

        [TestMethod()]
        public void MinusTestUnderZero()
        {
            var number = Claculator.Minus(5, 10);
            Assert.AreEqual(-5, number);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var number = Claculator.Multiply(2, 5);
            Assert.AreEqual(number, 10);
        }

        [TestMethod()]
        public void DevidTest()
        {
            var number = Claculator.Devid(3, 3);
            Assert.AreEqual(1, number);
        }

        [TestMethod()]
        public void CalcTestplus()
        {
            var number = Claculator.Calc(2, 2, '+');
            Assert.AreEqual(4, number);
        }
        [TestMethod()]
        public void CalcTestminus()
        {
            var number = Claculator.Calc(2, 2, '-');
            Assert.AreEqual(0, number);
        }
        public void CalcTestmulty()
        {
            var number = Claculator.Calc(5, 2, '*');
            Assert.AreEqual(10, number);
        }
        public void CalcTestdevid()
        {
            var number = Claculator.Calc(4, 4, '/');
            Assert.AreEqual(1, number);
        }
    }
}