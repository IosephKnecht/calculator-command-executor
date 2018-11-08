using app;

namespace arifmetical_library
{
    public class DivisionWithRemainderCommand:TwoOperandCommand
    {
        public override double Execute()
        {
            checkUnexpectedValue(firstOperand);
            checkUnexpectedValue(secondOperand);
            return firstOperand % secondOperand;
        }

        public override string ToString()
        {
            return "division with remainder";
        }
    }
}
