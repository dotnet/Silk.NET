// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

namespace InvokeBenchmarks
{
    public sealed class TestContext : INativeContext
    {
        private readonly UnmanagedLibrary _lib;

        public TestContext()
        {
            _lib = new UnmanagedLibrary("TestLib.dll");
        }

        public void Dispose()
        {
            _lib.Dispose();
        }
        
        public nint GetProcAddress(string proc, int? slot = default)
        {
            TryGetProcAddress(proc, out var v, slot);
            return v;
        }

        public bool TryGetProcAddress(string proc, out nint addr, int? slot = default)
        {
            addr = _lib.LoadFunction(proc);
            return addr != 0;
        }
    }
}
