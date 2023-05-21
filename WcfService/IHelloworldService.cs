using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    internal interface IHelloworldService
    {
        [OperationContract]
        String GetMessage(string name);
    }
}
