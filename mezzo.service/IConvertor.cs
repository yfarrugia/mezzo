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

        decimal DegreesToDecimals(double degrees);

        double DecimalsToRadians(decimal decimals);

        decimal DegreesToCartesian(double degrees);

        double CartesianToDegrees(decimal cartesian);
    }
}
