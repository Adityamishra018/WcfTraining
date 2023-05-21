using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfService;

namespace HostCmdLineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(WcfService.HelloworldService), new Uri("http://localhost:5255/HostCmdLineApp/HelloWorldService.svc"));
            host.Open();

            Console.WriteLine("Service is running now");
            Console.WriteLine("Press any key to close it");

            Console.ReadKey();
            host.Close();
        }
    }
}
