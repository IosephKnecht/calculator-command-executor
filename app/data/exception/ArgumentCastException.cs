using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.data.exception
{
    /// <summary>
    /// Custom exception for operand type cast error.
    /// </summary>
    class ArgumentCastException:Exception
    {
        public ArgumentCastException() : base("One of the arguments is of wrong type")
        {

        }
    }
}
