using System;
using app;

namespace arifmetical_library
{
    public class NaturalLogarithmCommand:OneOperandCommand
    {
        public override double Execute()
        {
            return Math.Log(operand);
        }

        public override string ToString()
        {
            return "natural logarithm";
        }
    }
}
