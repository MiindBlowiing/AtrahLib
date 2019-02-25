using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtrahLib.AMath;
using AtrahLib.AMath.Vector;
using Array = AtrahLib.Collections.Array;
namespace AtrahLib_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPolarAngle()
        {
            Vector2D test = new Vector2D(0,-1);
            double angle = test.GetPolarAngleDeg(test);
            float r = 270;
            Assert.IsTrue(Math.Abs(angle - r) < AMath.EPSILON);
        }

        [TestMethod]
        public void ArrayTest()
        {
            int[] test = new int[100];
        }
    }
}
