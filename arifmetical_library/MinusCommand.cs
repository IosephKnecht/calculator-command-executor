using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app;

namespace arifmetical_library
{
    public class MinusCommand:TwoOperandCommand
    {
        public override double Execute()
        {
            return firstOperand - secondOperand;
        }
    }
}
