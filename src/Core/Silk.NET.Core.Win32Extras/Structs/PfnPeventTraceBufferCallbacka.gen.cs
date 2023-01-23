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
    public unsafe readonly struct PfnPeventTraceBufferCallbacka : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<EventTraceLogfilea*, uint> Handle => (delegate* unmanaged[Cdecl]<EventTraceLogfilea*, uint>) _handle;
        public PfnPeventTraceBufferCallbacka
        (
            delegate* unmanaged[Cdecl]<EventTraceLogfilea*, uint> ptr
        ) => _handle = ptr;

        public PfnPeventTraceBufferCallbacka
        (
             PeventTraceBufferCallbacka proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPeventTraceBufferCallbacka From(PeventTraceBufferCallbacka proc) => new PfnPeventTraceBufferCallbacka(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPeventTraceBufferCallbacka pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPeventTraceBufferCallbacka(nint pfn)
            => new PfnPeventTraceBufferCallbacka((delegate* unmanaged[Cdecl]<EventTraceLogfilea*, uint>) pfn);

        public static implicit operator PfnPeventTraceBufferCallbacka(PeventTraceBufferCallbacka proc)
            => new PfnPeventTraceBufferCallbacka(proc);

        public static explicit operator PeventTraceBufferCallbacka(PfnPeventTraceBufferCallbacka pfn)
            => SilkMarshal.PtrToDelegate<PeventTraceBufferCallbacka>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<EventTraceLogfilea*, uint>(PfnPeventTraceBufferCallbacka pfn) => pfn.Handle;
        public static implicit operator PfnPeventTraceBufferCallbacka(delegate* unmanaged[Cdecl]<EventTraceLogfilea*, uint> ptr) => new PfnPeventTraceBufferCallbacka(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint PeventTraceBufferCallbacka(EventTraceLogfilea* arg0);
}

