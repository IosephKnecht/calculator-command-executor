using app;

namespace arifmetical_library
{
    public class DivisionWithRemainderCommand:TwoOperandCommand
    {
        protected override double Execute()
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
