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
    public unsafe readonly struct PfnRequestAdapterCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void>) _handle;
        public PfnRequestAdapterCallback
        (
            delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnRequestAdapterCallback
        (
             RequestAdapterCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRequestAdapterCallback From(RequestAdapterCallback proc) => new PfnRequestAdapterCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRequestAdapterCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRequestAdapterCallback(nint pfn)
            => new PfnRequestAdapterCallback((delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void>) pfn);

        public static implicit operator PfnRequestAdapterCallback(RequestAdapterCallback proc)
            => new PfnRequestAdapterCallback(proc);

        public static explicit operator RequestAdapterCallback(PfnRequestAdapterCallback pfn)
            => SilkMarshal.PtrToDelegate<RequestAdapterCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void>(PfnRequestAdapterCallback pfn) => pfn.Handle;
        public static implicit operator PfnRequestAdapterCallback(delegate* unmanaged[Cdecl]<RequestAdapterStatus, Adapter*, byte*, void*, void> ptr) => new PfnRequestAdapterCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void RequestAdapterCallback(RequestAdapterStatus arg0, Adapter* arg1, byte* arg2, void* arg3);
}

