using System;
using app;

namespace arifmetical_library
{
    public class NaturalLogarithmCommand:OneOperandCommand
    {
        protected override double Execute()
        {
            checkUnexpectedValue(operand);
            return Math.Log(operand);
        }

        public override string ToString()
        {
            return "natural logarithm";
        }
    }
}
