using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app;

namespace arifmetical_library
{
    public class SqrtCommand : OneOperandCommand
    {
        protected override Double Execute()
        {
            checkUnexpectedValue(operand);
            return Math.Sqrt(operand);
        }

        public override string ToString()
        {
            return "square root";
        }
    }
}
