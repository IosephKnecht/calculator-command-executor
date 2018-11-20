using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.one_operand_command
{
    [TestClass]
    public class TangensCommandTest : AbstractOneOperandCommandTest
    {
        [TestMethod]
        public override void PositiveTestOneOperandCommand()
        {
            setCommand(new TangensCommand());
            SetOperand(1);
            SetExpectedValue(1.557);
            base.PositiveTestOneOperandCommand();
        }

        [TestMethod]
        public override void NegativeTestOneOperandCommand()
        {
            setCommand(new TangensCommand());
            SetOperand(1);
            SetExpectedValue(2);
            base.NegativeTestOneOperandCommand();
        }
    }
}
