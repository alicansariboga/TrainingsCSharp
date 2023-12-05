using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Business
{
    public class ServiceMsgException : Exception
    {
        public ServiceMsgException(string message) : base(message)
        {

        }
    }
}
