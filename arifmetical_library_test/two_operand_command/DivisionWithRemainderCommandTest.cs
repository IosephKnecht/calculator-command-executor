using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace arifmetical_library_test.two_operand_command
{
    [TestClass]
    public class DivisionWithRemainderCommandTest : AbstractTwoOperandCommandUnitTest
    {
        [TestMethod]
        public override void TestTwoOperandCommand()
        {
            SetCommand(new DivisionWithRemainderCommand());
            SetFistOperand(155);
            SetSecondOperand(32);
            SetExpectedValue(27);
            base.TestTwoOperandCommand();
        }
    }
}
