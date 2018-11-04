using System;
using app;

namespace arifmetical_library
{
    public class TangensCommand:OneOperandCommand
    {
        public override double Execute()
        {
            return Math.Cos(operand);
        }
    }
}
