using app;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arifmetical_library_test
{
    public abstract class AbstractOneOperandCommandTest
    {
        private OneOperandCommand command;
        private Double operand;
        private Double expectedValue;

        protected void setCommand(OneOperandCommand command)
        {
            this.command = command;
        }

        protected void SetOperand(Double operand)
        {
            this.operand = operand;
            command.setOperand(operand);
        }

        protected void SetExpectedValue(Double expectedValue)
        {
            this.expectedValue = expectedValue;
        }

        public virtual void TestOneOperandCommand()
        {
            Assert.AreEqual(expectedValue, command.Execute());
        }
    }
}
