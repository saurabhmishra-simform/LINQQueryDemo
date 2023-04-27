using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionMethod
{
    public static class StringHelper
    {
        public static string ChangeStringFormat(this string str)
        {
            if (str.Length > 0)
            {
                char[] chars = str.ToCharArray();
                chars[0] = char.IsUpper(chars[0]) ? char.ToLower(chars[0]) : char.ToUpper(chars[0]);
                return new string(chars);
            }
            return str;
        }
    }
}
