﻿using app;

namespace arifmetical_library
{
    public class MinusCommand:TwoOperandCommand
    {
        public override double Execute()
        {
            return firstOperand - secondOperand;
        }
    }
}
