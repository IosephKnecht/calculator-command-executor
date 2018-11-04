using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{

    public interface ICommand
    {
        Double Execute();
        String GetName();
    }
}
