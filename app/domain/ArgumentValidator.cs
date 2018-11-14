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
            return !(Double.IsNaN(value) ||
                Double.IsNegativeInfinity(value) ||
                Double.IsPositiveInfinity(value));
        }
    }
}
