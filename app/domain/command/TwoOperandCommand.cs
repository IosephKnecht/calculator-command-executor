using app.data.exception;
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

        protected abstract Double Execute();

        public override string ToString()
        {
            return "It's not implemented two operand command";
        }

        public double SafeExecute()
        {
            if(checkUnexpectedValue(firstOperand)|| checkUnexpectedValue(secondOperand))
            {
                throw new UnexpectedValueException();
            }
            else
            {
                var result = Execute();
                if (checkUnexpectedValue(result))
                {
                    throw new UnexpectedValueException();
                }
                else
                {
                    return result;
                }
            }
        }

        public bool checkUnexpectedValue(double value)
        {
            return Double.IsNaN(value) ||
                Double.IsNegativeInfinity(value) ||
                Double.IsPositiveInfinity(value) ;
        }
    }
}
