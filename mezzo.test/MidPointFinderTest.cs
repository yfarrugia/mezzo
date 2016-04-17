using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mezzo.service;
using mezzo.dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mezzo.test
{
    [TestClass]
    public class MidPointFinderTest
    {  
        IMidPointFinder finder = new MidPointFinder(new Convertor());     

        [TestMethod]
        public void FindMidPoint()
        {
            //Input: List<Point> points
            var points = new List<Point>() { 
                new Point() { latitude = 51.523017, longitude = -0.16408743, modeOfTransport = ModeOfTransport.Driving },
                new Point() { latitude = 51.639167, longitude = -0.49846408, modeOfTransport = ModeOfTransport.Driving },
                new Point() { latitude = 51.5029, longitude = -0.27907, modeOfTransport = ModeOfTransport.Driving }};
            
            var midPoint= finder.FindMidPoint(points);

            Assert.IsNotNull(midPoint);
            //51.55511
            //-0.313711
            Assert.IsTrue(midPoint.latitude > 51);
            Assert.IsTrue(midPoint.longitude < -0.3);    
        }

        [TestMethod]
        public void CollaborateWithGoogleTest() {
            //Input: List<double[]> carPoints, List<double> weights, double totalWeight
            //HA0
            var originPoint = new Point() { latitude = 51.55511, longitude = -0.313711, modeOfTransport= ModeOfTransport.Driving };
            //WD3 8JN
            var destPoint = new Point() { latitude = 51.639167, longitude = -0.49846408 };
            var strOrigin = originPoint.latitude.ToString() + ',' + originPoint.longitude.ToString();
            var strDest = destPoint.latitude.ToString() + ',' + destPoint.longitude.ToString();

            //Input: string origin, string destination, string mode
            var google = finder.CollaborateWithGoogle(strOrigin, strDest, originPoint.modeOfTransport.ToString());

            Assert.IsNotNull(google);
            Assert.IsTrue(google > 18);
        }

        [TestMethod]
        public void FindCenterMidPointTest() {
            //Input: List<Point> points, Point midPoint
            var points = new List<Point>() { 
                new Point() { latitude = 51.523017, longitude = -0.16408743, modeOfTransport = ModeOfTransport.Driving },
                new Point() { latitude = 51.639167, longitude = -0.49846408, modeOfTransport = ModeOfTransport.Driving },
                new Point() { latitude = 51.5029, longitude = -0.27907, modeOfTransport = ModeOfTransport.Driving }};
            var midPoint = new Point() {latitude = 51.55511, longitude = -0.313711};

            var center = finder.FindCenterMidPoint(points, midPoint);
            Assert.IsNotNull(center);
        }
    }
}
