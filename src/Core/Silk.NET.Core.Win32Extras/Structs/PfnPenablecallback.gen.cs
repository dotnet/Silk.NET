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
    public unsafe readonly struct PfnPenablecallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Guid*, uint, byte, ulong, ulong, EventFilterDescriptor*, void*, void> Handle => (delegate* unmanaged[Cdecl]<Guid*, uint, byte, ulong, ulong, EventFilterDescriptor*, void*, void>) _handle;
        public PfnPenablecallback
        (
            delegate* unmanaged[Cdecl]<Guid*, uint, byte, ulong, ulong, EventFilterDescriptor*, void*, void> ptr
        ) => _handle = ptr;

        public PfnPenablecallback
        (
             Penablecallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPenablecallback From(Penablecallback proc) => new PfnPenablecallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPenablecallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPenablecallback(nint pfn)
            => new PfnPenablecallback((delegate* unmanaged[Cdecl]<Guid*, uint, byte, ulong, ulong, EventFilterDescriptor*, void*, void>) pfn);

        public static implicit operator PfnPenablecallback(Penablecallback proc)
            => new PfnPenablecallback(proc);

        public static explicit operator Penablecallback(PfnPenablecallback pfn)
            => SilkMarshal.PtrToDelegate<Penablecallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Guid*, uint, byte, ulong, ulong, EventFilterDescriptor*, void*, void>(PfnPenablecallback pfn) => pfn.Handle;
        public static implicit operator PfnPenablecallback(delegate* unmanaged[Cdecl]<Guid*, uint, byte, ulong, ulong, EventFilterDescriptor*, void*, void> ptr) => new PfnPenablecallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void Penablecallback(Guid* arg0, uint arg1, byte arg2, ulong arg3, ulong arg4, EventFilterDescriptor* arg5, void* arg6);
}

