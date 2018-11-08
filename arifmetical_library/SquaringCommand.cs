using System;
using app;

namespace arifmetical_library
{
    public class SquaringCommand:OneOperandCommand
    {
        public override double Execute()
        {
            checkUnexpectedValue(operand);
            return Math.Pow(operand, 2);
        }

        public override string ToString()
        {
            return "squaring";
        }
    }
}
