using System;
using app;

namespace arifmetical_library
{
    public class SinusCommand:OneOperandCommand
    {
        public override double Execute()
        {
            checkUnexpectedValue(operand);
            return Math.Sin(operand);
        }

        public override string ToString()
        {
            return "sinus";
        }
    }
}
