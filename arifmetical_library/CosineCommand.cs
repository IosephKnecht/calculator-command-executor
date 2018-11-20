using System;
using app;

namespace arifmetical_library
{
    public class CosineCommand:OneOperandCommand
    {
        protected override double Execute()
        {
            checkUnexpectedValue(operand);
            return Math.Cos(operand);
        }

        public override string ToString()
        {
            return "cosine";
        }
    }
}
