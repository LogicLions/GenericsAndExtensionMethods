using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public static class StringExtensions
    {
        public static string RightSubstring(this string str,int count) 
        {
            return str.Substring(str.Length - count, count);
        }
    }
}
