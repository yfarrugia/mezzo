using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using Autofac;
using Autofac.Integration.Wcf;
using mezzo.dto;

namespace mezzo.api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MidPointFinder" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MidPointFinder.svc or MidPointFinder.svc.cs at the Solution Explorer and start debugging.
    public class MidPointFinder : IMidPointFinder
    {

        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            // Register your service implementations
            builder.RegisterType<mezzo.service.MidPointFinder>().As<mezzo.service.IMidPointFinder>();
            builder.RegisterType<mezzo.service.Convertor>().As<mezzo.service.IConvertor>();
            builder.RegisterType<Point>();

            // Set the dependency resolver.
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }

        public Point FindMidPoint(List<Point> points)
        {
            // Create the scope, resolve your IMidPointFinder, use it, then dispose of the scope.
            using (var scope = AutofacHostFactory.Container.BeginLifetimeScope())
            {
                var midPointFinder = scope.Resolve<IMidPointFinder>();
                return midPointFinder.FindMidPoint(points);               
            }            
        }                

        public Point FindCenterMidPoint(List<Point> points, Point midPoint)
        {            
            // Create the scope, resolve your IMidPointFinder, use it, then dispose of the scope.
            using (var scope = AutofacHostFactory.Container.BeginLifetimeScope())
            {
                var midPointFinder = scope.Resolve<IMidPointFinder>();
                return midPointFinder.FindCenterMidPoint(points, midPoint);
            }
        }

        //public double[] ComputeWeightedAverage(List<double[]> carPoints, List<double> weights, double totalWeight)
        //{
        //    var weightedAverage = new double[]();

        //    // Create the scope, resolve your IMidPointFinder, use it, then dispose of the scope.
        //    using (var scope = AutofacHostFactory.Container.BeginLifetimeScope())
        //    {
        //        var midPointFinder = scope.Resolve<IMidPointFinder>();
        //        weightedAverage = midPointFinder.ComputeWeightedAverage(carPoints, weights, totalWeight);
        //    }

        //    return weightedAverage;
        //}
    }
}
