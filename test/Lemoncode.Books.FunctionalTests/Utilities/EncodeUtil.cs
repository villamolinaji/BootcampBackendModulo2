using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemoncode.Books.FunctionalTests.Utilities
{
    public static class EncodeUtil
    {
        public static string EncodeToBase64(string value)
        {

            byte[] toEncodeAsBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(toEncodeAsBytes);
        }
    }
}
