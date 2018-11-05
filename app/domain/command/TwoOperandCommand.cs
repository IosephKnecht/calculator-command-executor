using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    /// <summary>
    /// Class for two operand command;
    /// </summary>
    public abstract class TwoOperandCommand : ICommand
    {
        protected Double firstOperand;
        protected Double secondOperand;

        public virtual void setFirstOperand(Double operand)
        {
            this.firstOperand = operand;
        }

        public virtual void setSecondOperand(Double operand)
        {
            this.secondOperand = operand;
        }

        public abstract Double Execute();

        public virtual string GetName()
        {
            return "It's not implemented two operand command";
        }
    }
}
