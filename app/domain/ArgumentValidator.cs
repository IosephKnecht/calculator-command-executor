using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.domain
{
    /// <summary>
    /// Util for validation operand.
    /// </summary>
    static class ArgumentValidator
    {
        public static bool isDouble(object value)
        {
            try
            {
                var result = Convert.ToDouble(value);
                return checkUnexpectedValue(result);
            }
            catch
            {
                return false;
            }
        }

        private static bool checkUnexpectedValue(Double value)
        {
            if (value != null || value != double.NaN || value != double.NegativeInfinity
                || value != Double.PositiveInfinity)
            {
                return false;
            }
            return true;
        }
    }
}
