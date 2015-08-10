using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleNS;

namespace TriangleTestNS
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleInequalityTest()
        {
            Triangle t = new Triangle(2, 3, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WrongSideLegthTest()
        {
            Triangle t = new Triangle(1, 2, 0);
        }

        [TestMethod]
        public void AreaTest()
        {
            Triangle t = new Triangle(3, 4, 5);

            double expected = 3 * 4 / 2;
            double area = t.Area();

            Assert.AreEqual(expected, area, 1E-3);
        }
    }

    [TestClass]
    public class RightTriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotRightTriangleTest()
        {
            RightTriangle t = new RightTriangle(1, 2, 3);
        }

        [TestMethod]
        public void CorrectRightTriangleTest()
        {
            RightTriangle t = new RightTriangle(3, 4, 5);
        }
    }
}
