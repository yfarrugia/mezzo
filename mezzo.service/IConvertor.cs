using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezzo.service
{
    public interface IConvertor
    {
        double DegreesToRadians(double degrees);

        double RadiansToDegrees(double radians);

        double[] RadiansToCartesian(double radLatitude, double radLongitude);

        double[] CartesianToRadians(double[] cartesian);
    }
}
