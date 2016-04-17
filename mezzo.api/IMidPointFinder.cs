using mezzo.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace mezzo.api
{
    [ServiceContract]
    public interface IMidPointFinder
    {
        [OperationContract]
        Point FindMidPoint(List<Point> points);

        [OperationContract]
        Point FindCenterMidPoint(List<Point> points, Point midPoint);

        //[OperationContract]
        //double[] ComputeWeightedAverage(List<double[]> carPoints, List<double> weights, double totalWeight);

        //[OperationContract]
        //double CollaborateWithGoogle(string origin, string destination, string mode);
    }
}
