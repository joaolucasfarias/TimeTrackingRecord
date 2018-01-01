using System;
using System.Text;
using Models;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string ToBase64(this string value) =>
            Convert.ToBase64String(Encoding.UTF8.GetBytes(value));

        public static string FromBase64(this string value) =>
            Encoding.UTF8.GetString(Convert.FromBase64String(value));
    }
}
