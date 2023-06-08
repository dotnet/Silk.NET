// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Loader
{
    internal static class Libdl
    {
        private const string LibName = "libdl.so.2";

        public const int RtldNow = 0x002;

        [DllImport(LibName)]
        public static extern nint dlopen(string fileName, int flags);

        [DllImport(LibName)]
        public static extern nint dlsym(nint handle, string name);

        [DllImport(LibName)]
        public static extern int dlclose(nint handle);

        [DllImport(LibName)]
        public static extern string dlerror();
    }
}
