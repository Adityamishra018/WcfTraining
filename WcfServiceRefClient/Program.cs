using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceRefClient.HelloworldServiceRef;

namespace WcfServiceRefClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new HelloworldServiceClient();
            Console.WriteLine(service.GetMessage("Aditya"));
        }
    }
}
