using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    public class HelloworldService : IHelloworldService
    {
        public string GetMessage(string name)
        {
            return "Hello World ! " + name;
        }
    }
}
