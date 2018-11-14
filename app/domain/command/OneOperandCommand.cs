using app.data.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    /// <summary>
    /// Class for one operand command.
    /// </summary>
    public abstract class OneOperandCommand : ICommand
    {
        protected Double operand;

        public virtual void setOperand(Double operand)
        {
            this.operand = operand;
        }

        public virtual Double SafeExecute()
        {
            if (checkUnexpectedValue(operand)) throw new UnexpectedValueException();
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

        protected abstract Double Execute();

        public override string ToString()
        {
            return "It's not implemented one operand command";
        }

        public bool checkUnexpectedValue(Double value)
        {
            return Double.IsNaN(value) ||
                Double.IsPositiveInfinity(value) ||
                Double.IsNegativeInfinity(value);
        }
    }
}
