using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Trackhive.NET.Extensions
{
    public static class SecureStringExtensions
    {
        public static string ToString(this SecureString input)
        {
            var unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(input);
                return Marshal.PtrToStringUni(unmanagedString) ?? string.Empty;
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}