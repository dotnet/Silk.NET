// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    public unsafe readonly struct PfnLogCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<LogLevel, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<LogLevel, byte*, void*, void>) _handle;
        public PfnLogCallback
        (
            delegate* unmanaged[Cdecl]<LogLevel, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnLogCallback
        (
             LogCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnLogCallback From(LogCallback proc) => new PfnLogCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnLogCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnLogCallback(nint pfn)
            => new PfnLogCallback((delegate* unmanaged[Cdecl]<LogLevel, byte*, void*, void>) pfn);

        public static implicit operator PfnLogCallback(LogCallback proc)
            => new PfnLogCallback(proc);

        public static explicit operator LogCallback(PfnLogCallback pfn)
            => SilkMarshal.PtrToDelegate<LogCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<LogLevel, byte*, void*, void>(PfnLogCallback pfn) => pfn.Handle;
        public static implicit operator PfnLogCallback(delegate* unmanaged[Cdecl]<LogLevel, byte*, void*, void> ptr) => new PfnLogCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void LogCallback(LogLevel arg0, byte* arg1, void* arg2);
}

