using System;
using app;

namespace arifmetical_library
{
    public class ArctangesCommand:OneOperandCommand
    {
        public override double Execute()
        {
            return Math.Atan(operand);
        }
    }
}
