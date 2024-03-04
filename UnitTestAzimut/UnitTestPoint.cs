using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Azimut;
using System.Collections.Generic;

namespace UnitTestAzimut
{
    [TestClass]
    public class UnitTestPoint
    {
        [DataRow(-1000, -1000)]
        [DataRow(1000, 1000)]
        [DataRow(1000, -1000)]
        [DataRow(-1000, 1000)]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataTestMethod]
        public void TestMethodCtor_ThrowsArgumentOutOfRangeException(double a, double b)
        {
            //arrange
            Point p;
            //act
            p = new Point(a, b);
        }
        [TestMethod]
        public void TestMethodCtorCreatePoint()
        {
            //arrange
            Point p;
            double a = 0.0;
            double b = 0.0;
            //act
            p = new Point(a, b);
            //assert
            Assert.IsNotNull(p);
        }

        [DataRow(-80, -170)]
        [DataRow(-80, 170)]
        [DataRow(80, -170)]
        [DataRow(80, 170)]

        [DataRow(-90, -180)]
        [DataRow(90, -180)]
        [DataRow(-90, 180)]
        [DataRow(90, 180)]

        [DataTestMethod]
        public void TestMethodCtor_ThrowsArgumentNOTOutOfRange(double a, double b)
        {
            //arrange
            Point p;
            //act
            p = new Point(a, b);
        }

        [DataTestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void TestMethodCtor(Point p1, Point p2)
        {
            //arrange
            //act

            //accert
        }
        public static IEnumerable<object[]> Data
        {
            yield return new object[] {new Point(0,0), new Point(50,70)}
            yield return new object[] {new Point(90,180), new Point(-90,180), new Point(90,-180), new Point(-90,-180)}
        }
    }
}

