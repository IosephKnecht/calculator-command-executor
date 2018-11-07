using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.one_operand_command
{
    [TestClass]
    public class ArctangensCommandTest:AbstractOneOperandCommandTest
    {
        [TestMethod]
        public override void PositiveTestOneOperandCommand()
        {
            setCommand(new ArctangesCommand());
            SetOperand(1);
            SetExpectedValue(0.785);
            base.PositiveTestOneOperandCommand();
        }

        [TestMethod]
        public override void NegativeTestOneOperandCommand()
        {
            setCommand(new ArctangesCommand());
            SetOperand(1);
            SetExpectedValue(2);
            base.NegativeTestOneOperandCommand();
        }
    }
}
