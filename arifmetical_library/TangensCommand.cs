using System;
using app;

namespace arifmetical_library
{
    public class TangensCommand:OneOperandCommand
    {
        public override double Execute()
        {
            checkUnexpectedValue(operand);
            return Math.Tan(operand);
        }

        public override string ToString()
        {
            return "tangens";
        }
    }
}
