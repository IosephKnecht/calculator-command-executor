using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.one_operand_command
{
    [TestClass]
    public class TangensCommandTest : AbstractOneOperandCommandTest
    {
        [TestMethod]
        public override void TestOneOperandCommand()
        {
            setCommand(new TangensCommand());
            SetOperand(0);
            SetExpectedValue(0);
            base.TestOneOperandCommand();
        }
    }
}
