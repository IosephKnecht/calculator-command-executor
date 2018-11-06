using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.two_operand_command
{
    [TestClass]
    public class MultiplyCommandTest : AbstractTwoOperandCommandUnitTest
    {
        [TestMethod]
        public override void TestTwoOperandCommand()
        {
            SetCommand(new MultiplyCommand());
            SetFistOperand(35);
            SetSecondOperand(20);
            SetExpectedValue(700);
            base.TestTwoOperandCommand();
        }
    }
}
