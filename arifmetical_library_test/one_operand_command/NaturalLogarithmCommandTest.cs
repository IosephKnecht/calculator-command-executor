using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.one_operand_command
{
    [TestClass]
    public class NaturalLogarithmCommandTest : AbstractOneOperandCommandTest
    {
        [TestMethod]
        public override void TestOneOperandCommand()
        {
            setCommand(new NaturalLogarithmCommand());
            SetOperand(1);
            SetExpectedValue(0);
            base.TestOneOperandCommand();
        }
    }
}
