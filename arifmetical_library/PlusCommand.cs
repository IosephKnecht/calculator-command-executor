using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app;

namespace arifmetical_library
{
    public class PlusCommand : TwoOperandCommand
    {
        public override Double Execute()
        {
            return firstOperand + secondOperand;
        }
    }
}
