using app;

namespace arifmetical_library
{
    public class MinusCommand:TwoOperandCommand
    {
        protected override double Execute()
        {
            checkUnexpectedValue(firstOperand);
            checkUnexpectedValue(secondOperand);
            return firstOperand - secondOperand;
        }

        public override string ToString()
        {
            return "minus";
        }
    }
}
