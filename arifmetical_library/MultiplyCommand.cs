﻿using app;

namespace arifmetical_library
{
    public class MultiplyCommand:TwoOperandCommand
    {
        public override double Execute()
        {
            return firstOperand * secondOperand;
        }
    }
}
