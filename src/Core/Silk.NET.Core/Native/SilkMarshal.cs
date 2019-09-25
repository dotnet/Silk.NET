// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public static class SilkMarshal
    {
        public static IntPtr MarshalStringToPtr(string str) => Marshal.StringToHGlobalAnsi(str);

        public static void FreeStringPtr(IntPtr ptr) => Marshal.FreeHGlobal(ptr);

        public static IntPtr MarshalStringArrayToPtr(string[] array)
        {
            var ptr = IntPtr.Zero;
            if (array != null && array.Length != 0)
            {
                ptr = Marshal.AllocHGlobal(array.Length * IntPtr.Size);
                if (ptr == IntPtr.Zero)
                {
                    throw new OutOfMemoryException();
                }

                var i = 0;
                try
                {
                    for (i = 0; i < array.Length; i++)
                    {
                        var str = MarshalStringToPtr(array[i]);
                        Marshal.WriteIntPtr(ptr, i * IntPtr.Size, str);
                    }
                }
                catch (OutOfMemoryException)
                {
                    for (i -= 1; i >= 0; --i)
                    {
                        Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
                    }

                    Marshal.FreeHGlobal(ptr);

                    throw;
                }
            }
            return ptr;
        }

        public static void FreeStringArrayPtr(IntPtr ptr, int length)
        {
            for (var i = 0; i < length; i++)
            {
                Marshal.FreeHGlobal(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }
            Marshal.FreeHGlobal(ptr);
        }
    }
}
