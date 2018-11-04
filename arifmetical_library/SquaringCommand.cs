using app;

namespace arifmetical_library
{
    public class SquaringCommand:OneOperandCommand
    {
        public override double Execute()
        {
            return operand * operand;
        }
    }
}
