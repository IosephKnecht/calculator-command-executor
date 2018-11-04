using app;

namespace arifmetical_library
{
    public class DivisionWithRemainderCommandl:TwoOperandCommand
    {
        public override double Execute()
        {
            return firstOperand % secondOperand;
        }
    }
}
