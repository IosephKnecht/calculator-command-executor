using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.data.exception
{
    class UnknownTypeCommand : Exception
    {
        public UnknownTypeCommand() : base("Type of command is undefinied")
        {
        }
    }
}
