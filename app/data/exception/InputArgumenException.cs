using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.data.exception
{
    /// <summary>
    /// Custom exception for illegal operand.
    /// </summary>
    class InputArgumenException: Exception
    {
        public InputArgumenException() : base("Sorry, command not enough arguments")
        {

        }
    }
}
