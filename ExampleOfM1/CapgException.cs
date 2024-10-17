using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfM1
{
    public class CapgException : Exception
    {
        public CapgException(string msg): base(msg)
        {
            
        }
    }
}
