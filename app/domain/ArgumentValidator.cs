using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.domain
{
    static class ArgumentValidator
    {
        public static bool isDouble(object value)
        {
            try
            {
                var result = Convert.ToDouble(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
