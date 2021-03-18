// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
