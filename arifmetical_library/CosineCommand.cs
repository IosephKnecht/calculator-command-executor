using System;
using app;

namespace arifmetical_library
{
    public class CosineCommand:OneOperandCommand
    {
        public override double Execute()
        {
            return Math.Cos(operand);
        }

        public override string ToString()
        {
            return "cosine";
        }
    }
}
