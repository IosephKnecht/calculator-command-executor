using app;

namespace arifmetical_library
{
    public class DivisionWithoutRemainderCommand:TwoOperandCommand
    {
        public override double Execute()
        {
            return firstOperand / secondOperand;
        }
    }
}
