using app;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arifmetical_library_test
{
    public abstract class AbstractTwoOperandCommandUnitTest
    {
        private Double firstOperand;
        private Double secondOperand;
        private Double expectedValue;
        private TwoOperandCommand command;


        protected void SetFistOperand(Double firstOperand)
        {
            this.firstOperand = firstOperand;
            this.command.setFirstOperand(firstOperand);
        }

        protected void SetSecondOperand(Double secondOperand)
        {
            this.secondOperand = secondOperand;
            this.command.setSecondOperand(secondOperand);
        }

        protected void SetExpectedValue(Double expectedValue)
        {
            this.expectedValue = expectedValue;
        }

        public void SetCommand(TwoOperandCommand command)
        {
            this.command = command;
        }

        public virtual void TestTwoOperandCommand()
        {
            Assert.AreEqual(expectedValue, this.command.Execute());
        }
    }
}
