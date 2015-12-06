using mezzo.service;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mezzo.test
{
    [TestClass]
    public class ConvertorTest
    {
        IConvertor convert = new Convertor();
        
        [TestMethod]
        public void DegreesToRadiansTest()
        {           
            var radians = convert.DegreesToRadians(120);

            Assert.IsNotNull(radians);
            Assert.IsTrue(radians > 2);
            Assert.IsTrue(radians == 2.0943951023931953);
        }
        
        [TestMethod]
        public void RadiansToDegreesTest()
        {           
            var degrees = convert.RadiansToDegrees(1.57);

            Assert.IsNotNull(degrees);
            Assert.IsTrue(degrees < 90);
            Assert.IsTrue(degrees > 89.9);
            Assert.IsTrue(degrees == 89.954373835539243);            
        }

        [TestMethod]
        public void RadiansToCartesian()
        {
            var cartesian = convert.RadiansToCartesian(0.73091096, -1.5294285);

            Assert.IsNotNull(cartesian);
            Assert.IsTrue(cartesian.Length == 3);
            Assert.IsTrue(cartesian[0] > 0.03079231);
            Assert.IsTrue(cartesian[1] < -0.74392960);
            Assert.IsTrue(cartesian[2] > 0.66754818);            
        }

        [TestMethod]
        public void CartesianToRadians()
        {
            var carty = new double[3] { 0.12824063, -0.75020731, 0.64125282 };
            
            var degrees = convert.CartesianToRadians(carty);

            Assert.IsNotNull(degrees);
            Assert.IsTrue(degrees.Length == 2);
            Assert.IsTrue(degrees[1] < -1.40149245);
            Assert.IsTrue(degrees[0] > 0.70015084);
        }
    }
}
