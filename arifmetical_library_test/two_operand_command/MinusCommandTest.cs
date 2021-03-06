﻿using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test.two_operand_command
{
    [TestClass]
    public class MinusCommandTest : AbstractTwoOperandCommandUnitTest
    {
        [TestMethod]
        public override void PositiveTestTwoOperandCommand()
        {
            SetCommand(new MinusCommand());
            SetFistOperand(30.5);
            SetSecondOperand(15);
            SetExpectedValue(15.5);
            base.PositiveTestTwoOperandCommand();
        }

        [TestMethod]
        public override void NegativeTestTwoOperandCommand()
        {
            SetCommand(new MinusCommand());
            SetFistOperand(30.5);
            SetSecondOperand(15);
            SetExpectedValue(15);
            base.NegativeTestTwoOperandCommand();
        }
    }
}
