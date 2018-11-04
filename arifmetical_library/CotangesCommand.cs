using System;
using app;

namespace arifmetical_library
{
    public class CotangesCommand:OneOperandCommand
    {
        public override double Execute()
        {
            return 1 / Math.Tan(operand);
        }
    }
}
