using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class TooFastException : Exception
    {
        public TooFastException() : base("It is to fast for this car")
        {

        }
    }
}
