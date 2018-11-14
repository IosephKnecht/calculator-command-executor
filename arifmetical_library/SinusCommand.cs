using System;
using app;

namespace arifmetical_library
{
    public class SinusCommand:OneOperandCommand
    {
        protected override double Execute()
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
