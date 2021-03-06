﻿using System;
using arifmetical_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace arifmetical_library_test
{
    [TestClass]
    public class PlusCommandTest : AbstractTwoOperandCommandUnitTest
    {
        [TestMethod]
        public override void PositiveTestTwoOperandCommand()
        {
            SetCommand(new PlusCommand());
            SetFistOperand(10);
            SetSecondOperand(10);
            SetExpectedValue(20);
            base.PositiveTestTwoOperandCommand();
        }

        [TestMethod]
        public override void NegativeTestTwoOperandCommand()
        {
            SetCommand(new PlusCommand());
            SetFistOperand(10);
            SetSecondOperand(10);
            SetExpectedValue(220);
            base.NegativeTestTwoOperandCommand();
        }
    }
}
