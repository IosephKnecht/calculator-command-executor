using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.one_operand_command
{
    [TestClass]
    public class CosineCommandTest : AbstractOneOperandCommandTest
    {
        [TestMethod]
        public override void TestOneOperandCommand()
        {
            setCommand(new CosineCommand());
            SetOperand(0);
            SetExpectedValue(1);
            base.TestOneOperandCommand();
        }
    }
}
