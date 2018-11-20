using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.one_operand_command
{
    [TestClass]
    public class SquaringCommandTest : AbstractOneOperandCommandTest
    {
        [TestMethod]
        public override void PositiveTestOneOperandCommand()
        {
            setCommand(new SquaringCommand());
            SetOperand(5);
            SetExpectedValue(25);
            base.PositiveTestOneOperandCommand();
        }

        [TestMethod]
        public override void NegativeTestOneOperandCommand()
        {
            setCommand(new SquaringCommand());
            SetOperand(5);
            SetExpectedValue(10);
            base.NegativeTestOneOperandCommand();
        }
    }
}
