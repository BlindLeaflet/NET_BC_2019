using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CalculatorExceptions : Exception 
    {
        public CalculatorExceptions(string message)
            :base(message)
        {

        }
    }
}
