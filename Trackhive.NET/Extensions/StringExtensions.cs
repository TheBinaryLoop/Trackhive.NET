using System.Security;

namespace Trackhive.NET.Extensions
{
    public static class StringExtensions
    {
        public static SecureString ToSecureString(this string input)
        {
            var secStr = new SecureString();
            if (input.Length <= 0) return secStr;
            foreach (var c in input.ToCharArray()) secStr.AppendChar(c);
            return secStr;
        }
    }
}