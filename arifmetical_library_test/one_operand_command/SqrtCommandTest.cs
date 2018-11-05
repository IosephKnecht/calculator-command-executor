using System;
using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.one_operand_command
{
    [TestClass]
    public class SqrtCommandTest:AbstractOneOperandCommandTest
    {
        [TestMethod]
        public override void TestOneOperandCommand()
        {
            setCommand(new SqrtCommand());
            SetOperand(100);
            SetExpectedValue(10);
            base.TestOneOperandCommand();
        }
    }
}
