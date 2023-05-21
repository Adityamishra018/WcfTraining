using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceClient
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
