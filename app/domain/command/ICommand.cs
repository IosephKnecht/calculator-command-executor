using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{

    public interface ICommand
    {
        /// <summary>
        /// Method execute action in command;
        /// </summary>
        /// <returns></returns>
        Double Execute();

        void checkUnexpectedValue(Double value);
    }
}
