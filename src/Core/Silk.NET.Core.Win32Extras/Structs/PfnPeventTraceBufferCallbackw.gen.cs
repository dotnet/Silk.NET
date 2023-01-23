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

namespace Silk.NET.Core.Win32Extras
{
    public unsafe readonly struct PfnPeventTraceBufferCallbackw : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<EventTraceLogfilew*, uint> Handle => (delegate* unmanaged[Cdecl]<EventTraceLogfilew*, uint>) _handle;
        public PfnPeventTraceBufferCallbackw
        (
            delegate* unmanaged[Cdecl]<EventTraceLogfilew*, uint> ptr
        ) => _handle = ptr;

        public PfnPeventTraceBufferCallbackw
        (
             PeventTraceBufferCallbackw proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPeventTraceBufferCallbackw From(PeventTraceBufferCallbackw proc) => new PfnPeventTraceBufferCallbackw(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPeventTraceBufferCallbackw pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPeventTraceBufferCallbackw(nint pfn)
            => new PfnPeventTraceBufferCallbackw((delegate* unmanaged[Cdecl]<EventTraceLogfilew*, uint>) pfn);

        public static implicit operator PfnPeventTraceBufferCallbackw(PeventTraceBufferCallbackw proc)
            => new PfnPeventTraceBufferCallbackw(proc);

        public static explicit operator PeventTraceBufferCallbackw(PfnPeventTraceBufferCallbackw pfn)
            => SilkMarshal.PtrToDelegate<PeventTraceBufferCallbackw>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<EventTraceLogfilew*, uint>(PfnPeventTraceBufferCallbackw pfn) => pfn.Handle;
        public static implicit operator PfnPeventTraceBufferCallbackw(delegate* unmanaged[Cdecl]<EventTraceLogfilew*, uint> ptr) => new PfnPeventTraceBufferCallbackw(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint PeventTraceBufferCallbackw(EventTraceLogfilew* arg0);
}

