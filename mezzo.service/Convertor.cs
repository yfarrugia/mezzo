using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezzo.service
{
    public class Convertor : IConvertor
    {
        /// <summary>
        /// Converts Latitutde/Longitude from degrees to radians.
        /// Formula: radians = degrees * PI/180
        /// </summary>
        /// <param name="degrees">Latitutde/Longitude Value in Degrees in decimal format</param>
        /// <returns>Latitutde/Longitude Value in Radians</returns>
        public double DegreesToRadians(double degrees) {
            var rad = (degrees * (Math.PI / 180.0));
            return rad;
        }

        /// <summary>
        /// Converts Latitutde/Longitude from radians to degrees.
        /// Formula: radians = degrees * 180/PI
        /// </summary>
        /// <param name="radians">Latitutde/Longitude Value Radian</param>
        /// <returns>Latitutde/Longitude Value in Degrees in decimal format</returns>
        public double RadiansToDegrees(double radians)
        {           
            var degrees = (radians * (180.0 / Math.PI));
            return degrees;
        }

        /// <summary>
        /// Converts Latitude & Longitude from Radians to Cartesian.
        /// Formula:
        ///     X1 = cos(lat) * cos(lon)
        ///     Y1 = cos(lat) * sin(lon)
        ///     Z1 = sin(lat)
        /// </summary>
        /// <param name="radLatitude">Latitude in Radians</param>
        /// <param name="radLongitude">Longitude in Radians</param>
        /// <returns>Latitude & Longitude in Cartesian Format (x,y,z) using an array of 3 doubles</returns>
        public double[] RadiansToCartesian(double radLatitude, double radLongitude)
        {
            double[] cartesian = new double[3];
            
            cartesian[0] = Math.Cos(radLatitude) * Math.Cos(radLongitude);
            cartesian[1] = Math.Cos(radLatitude) * Math.Sin(radLongitude);
            cartesian[2] = Math.Sin(radLatitude);
            
            return cartesian;
        }

        /// <summary>
        /// Converts Latitude & Longitude from Cartesian to Radians.
        /// Formula:
        ///     Lon = atan2(y, x)
        ///     Hyp = sqrt(x * x + y * y)
        ///     Lat = atan2(z, hyp)
        /// </summary>
        /// <param name="cartesian">Latitude & Longitude in Cartesian Format (x,y,z) using an array of 3 doubles</param>
        /// <returns>Latitude & Longitude in Radian Format (x,y) using an array of 2 doubles</returns>
        public double[] CartesianToRadians(double[] cartesian) 
        {
            double[] radians = new double[2];
            
            var longitude = Math.Atan2(cartesian[1], cartesian[0]);
            var hyp = Math.Sqrt((cartesian[0] * cartesian[0]) + (cartesian[1] * cartesian[1]));
            var latitude = Math.Atan2(cartesian[2], hyp);

            radians[0] = latitude;
            radians[1] = longitude;

            return radians;
        }
    }
}
