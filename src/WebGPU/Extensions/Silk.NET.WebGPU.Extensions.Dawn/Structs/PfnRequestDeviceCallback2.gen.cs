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
    public unsafe readonly struct PfnRequestDeviceCallback2 : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void*, void> Handle => (delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void*, void>) _handle;
        public PfnRequestDeviceCallback2
        (
            delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void*, void> ptr
        ) => _handle = ptr;

        public PfnRequestDeviceCallback2
        (
             RequestDeviceCallback2 proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRequestDeviceCallback2 From(RequestDeviceCallback2 proc) => new PfnRequestDeviceCallback2(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRequestDeviceCallback2 pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRequestDeviceCallback2(nint pfn)
            => new PfnRequestDeviceCallback2((delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void*, void>) pfn);

        public static implicit operator PfnRequestDeviceCallback2(RequestDeviceCallback2 proc)
            => new PfnRequestDeviceCallback2(proc);

        public static explicit operator RequestDeviceCallback2(PfnRequestDeviceCallback2 pfn)
            => SilkMarshal.PtrToDelegate<RequestDeviceCallback2>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void*, void>(PfnRequestDeviceCallback2 pfn) => pfn.Handle;
        public static implicit operator PfnRequestDeviceCallback2(delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void*, void> ptr) => new PfnRequestDeviceCallback2(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void RequestDeviceCallback2(RequestDeviceStatus arg0, Device* arg1, byte* arg2, void* arg3, void* arg4);
}

