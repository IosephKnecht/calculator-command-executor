using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.data.exception
{
    class UnexpectedValueException : Exception
    {
        public UnexpectedValueException() : base("Value Inf or Nan")
        {

        }
    }
}
