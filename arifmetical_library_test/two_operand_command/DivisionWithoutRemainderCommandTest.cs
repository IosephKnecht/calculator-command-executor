using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.two_operand_command
{
 
    public class DivisionWithoutRemainderCommandTest : AbstractTwoOperandCommandUnitTest
    {
        [TestMethod]
        public override void PositiveTestTwoOperandCommand()
        {
            SetCommand(new DivisionWithoutRemainderCommand());
            SetFistOperand(50);
            SetSecondOperand(30);
            SetExpectedValue(1);
            base.PositiveTestTwoOperandCommand();
        }

        [TestMethod]
        public override void NegativeTestTwoOperandCommand()
        {
            SetCommand(new DivisionWithoutRemainderCommand());
            SetFistOperand(50);
            SetSecondOperand(30);
            SetExpectedValue(0);
            base.NegativeTestTwoOperandCommand();
        }
    }
}
