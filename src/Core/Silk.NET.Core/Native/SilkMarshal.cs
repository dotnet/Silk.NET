// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public static class SilkMarshal
    {
        public static unsafe char** ToPointer(IReadOnlyList<string> strings)
        {
            var res = stackalloc char*[strings.Count];
            for (var i = 0; i < strings.Count; i++)
            {
                res[i] = (char*)Marshal.StringToHGlobalAnsi(strings[i]);
            }

            return res;
        }

        public static unsafe IReadOnlyList<string> ToStringArray(char** strings, int count)
        {
            var array = new string[count];

            if (count == 0)
            {
                return new string[0]; // empty
            }

            if (strings == (char**)0)
            {
                return null; // nullptr
            }

            for (var i = 0; i < count; i += IntPtr.Size)
            {
                var p = Marshal.ReadIntPtr((IntPtr) strings, i);
                array[i] = Marshal.PtrToStringAnsi(p);
            }

            return array;
        }
    }
}
