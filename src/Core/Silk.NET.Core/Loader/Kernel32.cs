// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Loader
{
    internal static class Kernel32
    {
        [DllImport("kernel32")]
        public static extern nint LoadLibrary(string fileName);

        [DllImport("kernel32")]
        public static extern nint GetProcAddress(nint module, string procName);

        [DllImport("kernel32")]
        public static extern int FreeLibrary(nint module);
    }
}
