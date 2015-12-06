using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezzo.service
{
    public class Convertor : IConvertor
    {
        public double DegreesToRadians(double degrees) { 
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Radians
            var rad = (degrees * Math.PI / 180.0);
            return rad;
        }

        public double RadiansToDegrees(double radians)
        {
            //Input: Latitude and Longitude in Radians
            //Output: Latitude and Longitude in Degrees
            var degrees = (radians / Math.PI * 180.0);
            return degrees;
        }

        public decimal DegreesToDecimals(double degrees)
        {
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Decimals
            return 0;
        }

        public double DecimalsToRadians(decimal decimals) 
        {
            //Input: Latitude and Longitude in Decimals
            //Output: Latitude and Longitude in Radians
            return 0;
        }

        public decimal DegreesToCartesian(double degrees)
        {
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Cartesian
            return 0;
        }

        public double CartesianToDegrees(decimal cartesian) {
            //Input: Latitude and Longitude in Degrees
            //Output: Latitude and Longitude in Cartesian
            return 0;
        }
    }
}
