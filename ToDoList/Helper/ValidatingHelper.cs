using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Helper
{
    public class ValidatingHelper
    {
        public static (DateTime, bool) CheckDateTime<T>(T value)
        {
            if (value is DateTime) return (DateTime.Parse(value.ToString()), true);
            if (DateTimeTryParseExact(value.ToString()
                                        ,out DateTime result))
                return (result,true);
            if (DateTimeTryParseExact(value.ToString()
                                        , out result
                                        , "yyyy/M/d"))
                return (result, true);

            return (DateTime.MinValue, false);
        }

        private static bool DateTimeTryParseExact(string value,out DateTime result, string format = "yyyy/MM/dd")
        {
            return DateTime.TryParseExact(value
                                        , format
                                        , CultureInfo.CurrentCulture
                                        , DateTimeStyles.None
                                        , out result);
        }

        public static bool CheckNullOrStringEmpty<T>(T value)
        {
            if (value == null) return true;
            return string.IsNullOrWhiteSpace(value.ToString());
        }
    }
}
