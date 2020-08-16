// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// A helper class that marshals between native and managed types.
    /// </summary>
    public static class SilkMarshal
    {
        /// <summary>
        /// Allocate a new BStr pointer.
        /// </summary>
        /// <param name="length">The length of the string pointer, in bytes.</param>
        /// <returns>A pointer to the created string.</returns>
        public static IntPtr AllocBStr(int length) => Marshal.StringToBSTR(new string('\0', length));
        
        /// <summary>
        /// Converts a C# string to an ANSI string pointer.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>A pointer to a native ANSI string.</returns>
        public static IntPtr MarshalStringToPtr(string str)
        {
            return Marshal.StringToHGlobalAnsi(str);
        }

        /// <summary>
        /// Converts an ANSI string pointer to a C# string.
        /// </summary>
        /// <param name="str">A pointer to the ANSI string to convert.</param>
        /// <returns>A C# string.</returns>
        public static string MarshalPtrToString(IntPtr str)
        {
            return Marshal.PtrToStringAnsi(str);
        }

        /// <summary>
        /// Free a string pointer.
        /// </summary>
        /// <param name="ptr">The pointer to free.</param>
        public static void FreeStringPtr(IntPtr ptr)
        {
            Marshal.FreeHGlobal(ptr);
        }

        /// <summary>
        /// Allocate a new string pointer.
        /// </summary>
        /// <param name="length">The length of the string pointer, in bytes.</param>
        /// <returns>A pointer to the created string.</returns>
        public static IntPtr NewStringPtr(int length)
        {
            return Marshal.AllocHGlobal(length);
        }

        /// <summary>
        /// Allocate a new string pointer.
        /// </summary>
        /// <param name="length">The length of the string pointer, in bytes.</param>
        /// <returns>A pointer to the created string.</returns>
        public static IntPtr NewStringPtr(uint length)
        {
            return Marshal.AllocHGlobal((int) length);
        }

        /// <summary>
        /// Convert an array of strings into a pointer.
        /// </summary>
        /// <param name="array">The array of strings to convert.</param>
        /// <returns>The new pointer.</returns>
        /// <exception cref="OutOfMemoryException">Thrown if enough memory cannot be allocated.</exception>
        public static IntPtr MarshalStringArrayToPtr(IReadOnlyList<string> array)
        {
            var ptr = IntPtr.Zero;
            if (array != null && array.Count != 0)
            {
                ptr = Marshal.AllocHGlobal(array.Count * IntPtr.Size);
                if (ptr == IntPtr.Zero)
                {
                    throw new OutOfMemoryException();
                }

                var i = 0;
                try
                {
                    for (i = 0; i < array.Count; i++)
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

        /// <summary>
        /// Convert a pointer to a string array.
        /// </summary>
        /// <param name="ptr">The pointer to convert.</param>
        /// <param name="length">The number of strings in the pointer.</param>
        /// <returns>An array of strings.</returns>
        public static string[] MarshalPtrToStringArray(IntPtr ptr, int length)
        {
            var ret = new string[length];
            CopyPtrToStringArray(ptr, ret);
            return ret;
        }

        // TODO: Verify that this works without the array being an out parameter.
        /// <summary>
        /// Convert a pointer to an array of strings.
        /// </summary>
        /// <param name="ptr">The pointer to convert.</param>
        /// <param name="arr">The array to fill with strings.</param>
        public static void CopyPtrToStringArray(IntPtr ptr, string[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(ptr, i * IntPtr.Size));
            }
        }

        /// <summary>
        /// Free an array of strings.
        /// </summary>
        /// <param name="ptr">The pointer to free.</param>
        /// <param name="length">The number of strings in the pointer.</param>
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
