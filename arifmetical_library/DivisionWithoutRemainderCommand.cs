using app;

namespace arifmetical_library
{
    public class DivisionWithoutRemainderCommand:TwoOperandCommand
    {
        public override double Execute()
        {
            checkUnexpectedValue(firstOperand);
            checkUnexpectedValue(secondOperand);
            return firstOperand / secondOperand;
        }

        public override string ToString()
        {
            return "division without remainder";
        }
    }
}
