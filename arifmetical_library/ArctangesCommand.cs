using System;
using app;

namespace arifmetical_library
{
    public class ArctangesCommand:OneOperandCommand
    {
        public override double Execute()
        {
            checkUnexpectedValue(operand);
            return Math.Atan(operand);
        }

        public override string ToString()
        {
            return "arctangent";
        }
    }
}
