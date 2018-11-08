﻿using app.data.exception;
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

        public abstract Double Execute();

        public override string ToString()
        {
            return "It's not implemented one operand command";
        }

        public void checkUnexpectedValue(Double value)
        {
            if (value != null || value != double.NaN || value != double.NegativeInfinity
                || value != Double.PositiveInfinity)
            {
                throw new UnexpectedValueException();
            }
        }
    }
}
