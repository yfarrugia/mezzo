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
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Radians
            var radians = convert.DegreesToRadians(120);

            Assert.IsNotNull(radians);
            Assert.IsTrue(radians > 2);
            Assert.IsTrue(radians == 2.0943951023931953);
        }
        
        [TestMethod]
        public void RadiansToDegreesTest()
        {
            //Input: Latitude and Longitude in Radians
            //Output: Latitude and Longitude in Degrees
            var degrees = convert.RadiansToDegrees(1.57);

            Assert.IsNotNull(degrees);
            Assert.IsTrue(degrees < 90);
            Assert.IsTrue(degrees > 89.9);
            Assert.IsTrue(degrees == 89.954373835539258);
        }

        [TestMethod]
        public void DegreesToDecimalsTest()
        {
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Decimals
            var decimals = convert.DegreesToDecimals(123);
        }

        [TestMethod]
        public void DecimalsToRadiansTest()
        {
            //Input: Latitude and Longitude in Decimals
            //Output: Latitude and Longitude in Radians
            var radians = convert.DecimalsToRadians(123);
        }

        [TestMethod]
        public void DegreesToCartesianTest()
        {
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Cartesian
            var cartesian = convert.DegreesToCartesian(111);             
        }

        [TestMethod]
        public void CartesianToDegreesTest()
        {
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Cartesian
            var degrees = convert.CartesianToDegrees(123);            
        }
    }
}
