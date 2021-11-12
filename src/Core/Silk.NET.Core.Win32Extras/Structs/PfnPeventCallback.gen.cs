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
    public unsafe readonly struct PfnPeventCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<EventTrace*, void> Handle => (delegate* unmanaged[Cdecl]<EventTrace*, void>) _handle;
        public PfnPeventCallback
        (
            delegate* unmanaged[Cdecl]<EventTrace*, void> ptr
        ) => _handle = ptr;

        public PfnPeventCallback
        (
             PeventCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPeventCallback From(PeventCallback proc) => new PfnPeventCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPeventCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPeventCallback(nint pfn)
            => new PfnPeventCallback((delegate* unmanaged[Cdecl]<EventTrace*, void>) pfn);

        public static implicit operator PfnPeventCallback(PeventCallback proc)
            => new PfnPeventCallback(proc);

        public static explicit operator PeventCallback(PfnPeventCallback pfn)
            => SilkMarshal.PtrToDelegate<PeventCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<EventTrace*, void>(PfnPeventCallback pfn) => pfn.Handle;
        public static implicit operator PfnPeventCallback(delegate* unmanaged[Cdecl]<EventTrace*, void> ptr) => new PfnPeventCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PeventCallback(EventTrace* arg0);
}

