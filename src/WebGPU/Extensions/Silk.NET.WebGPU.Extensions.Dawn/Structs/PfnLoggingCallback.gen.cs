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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    public unsafe readonly struct PfnLoggingCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<LoggingType, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<LoggingType, byte*, void*, void>) _handle;
        public PfnLoggingCallback
        (
            delegate* unmanaged[Cdecl]<LoggingType, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnLoggingCallback
        (
             LoggingCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnLoggingCallback From(LoggingCallback proc) => new PfnLoggingCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnLoggingCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnLoggingCallback(nint pfn)
            => new PfnLoggingCallback((delegate* unmanaged[Cdecl]<LoggingType, byte*, void*, void>) pfn);

        public static implicit operator PfnLoggingCallback(LoggingCallback proc)
            => new PfnLoggingCallback(proc);

        public static explicit operator LoggingCallback(PfnLoggingCallback pfn)
            => SilkMarshal.PtrToDelegate<LoggingCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<LoggingType, byte*, void*, void>(PfnLoggingCallback pfn) => pfn.Handle;
        public static implicit operator PfnLoggingCallback(delegate* unmanaged[Cdecl]<LoggingType, byte*, void*, void> ptr) => new PfnLoggingCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void LoggingCallback(LoggingType arg0, byte* arg1, void* arg2);
}

