using Dealership.Engine;
using DealershipRedone;
using DealershipRedone.InputOutputProvider;
using Ninject;
using System;
using System.IO;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            DealershipEngine.Instance.Start();

            IKernel kernel = new StandardKernel(new DealershipModule());
        }
    }
}
