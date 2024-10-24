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
    public unsafe readonly struct PfnRequestAdapterCallback2 : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void*, void> Handle => (delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void*, void>) _handle;
        public PfnRequestAdapterCallback2
        (
            delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void*, void> ptr
        ) => _handle = ptr;

        public PfnRequestAdapterCallback2
        (
             RequestAdapterCallback2 proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRequestAdapterCallback2 From(RequestAdapterCallback2 proc) => new PfnRequestAdapterCallback2(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRequestAdapterCallback2 pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRequestAdapterCallback2(nint pfn)
            => new PfnRequestAdapterCallback2((delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void*, void>) pfn);

        public static implicit operator PfnRequestAdapterCallback2(RequestAdapterCallback2 proc)
            => new PfnRequestAdapterCallback2(proc);

        public static explicit operator RequestAdapterCallback2(PfnRequestAdapterCallback2 pfn)
            => SilkMarshal.PtrToDelegate<RequestAdapterCallback2>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void*, void>(PfnRequestAdapterCallback2 pfn) => pfn.Handle;
        public static implicit operator PfnRequestAdapterCallback2(delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void*, void> ptr) => new PfnRequestAdapterCallback2(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void RequestAdapterCallback2(RequestAdapterStatus arg0, Adapter* arg1, byte* arg2, void* arg3, void* arg4);
}

