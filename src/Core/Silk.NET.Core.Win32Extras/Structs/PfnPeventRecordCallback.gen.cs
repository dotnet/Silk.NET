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
    public unsafe readonly struct PfnPeventRecordCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<EventRecord*, void> Handle => (delegate* unmanaged[Cdecl]<EventRecord*, void>) _handle;
        public PfnPeventRecordCallback
        (
            delegate* unmanaged[Cdecl]<EventRecord*, void> ptr
        ) => _handle = ptr;

        public PfnPeventRecordCallback
        (
             PeventRecordCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPeventRecordCallback From(PeventRecordCallback proc) => new PfnPeventRecordCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPeventRecordCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPeventRecordCallback(nint pfn)
            => new PfnPeventRecordCallback((delegate* unmanaged[Cdecl]<EventRecord*, void>) pfn);

        public static implicit operator PfnPeventRecordCallback(PeventRecordCallback proc)
            => new PfnPeventRecordCallback(proc);

        public static explicit operator PeventRecordCallback(PfnPeventRecordCallback pfn)
            => SilkMarshal.PtrToDelegate<PeventRecordCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<EventRecord*, void>(PfnPeventRecordCallback pfn) => pfn.Handle;
        public static implicit operator PfnPeventRecordCallback(delegate* unmanaged[Cdecl]<EventRecord*, void> ptr) => new PfnPeventRecordCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PeventRecordCallback(EventRecord* arg0);
}

