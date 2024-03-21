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

namespace Silk.NET.WebGPU
{
    public unsafe readonly struct PfnInstanceRequestAdapterCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void>) _handle;
        public PfnInstanceRequestAdapterCallback
        (
            delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnInstanceRequestAdapterCallback
        (
             InstanceRequestAdapterCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnInstanceRequestAdapterCallback From(InstanceRequestAdapterCallback proc) => new PfnInstanceRequestAdapterCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnInstanceRequestAdapterCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnInstanceRequestAdapterCallback(nint pfn)
            => new PfnInstanceRequestAdapterCallback((delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void>) pfn);

        public static implicit operator PfnInstanceRequestAdapterCallback(InstanceRequestAdapterCallback proc)
            => new PfnInstanceRequestAdapterCallback(proc);

        public static explicit operator InstanceRequestAdapterCallback(PfnInstanceRequestAdapterCallback pfn)
            => SilkMarshal.PtrToDelegate<InstanceRequestAdapterCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void>(PfnInstanceRequestAdapterCallback pfn) => pfn.Handle;
        public static implicit operator PfnInstanceRequestAdapterCallback(delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void> ptr) => new PfnInstanceRequestAdapterCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void InstanceRequestAdapterCallback(RequestAdapterStatus arg0, Adapter* arg1, byte* arg2, void* arg3);
}

