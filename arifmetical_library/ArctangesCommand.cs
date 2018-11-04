using System;
using app;

namespace arifmetical_library
{
    public class CotangesCommand:OneOperandCommand
    {
        public override double Execute()
        {
            return Math.Atan(operand);
        }
    }
}
