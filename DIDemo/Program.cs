using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                app.Run();
            }

                #region hide
                //var container = ContainerConfig.Configure();
                //using (var scope = container.BeginLifetimeScope())
                //{
                //    var app = scope.Resolve<IApplication>();

                //    app.Run();
                //}
                #endregion


                Console.ReadLine();
        }
    }
}
