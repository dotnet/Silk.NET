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
    public unsafe readonly struct PfnRequestDeviceCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void>) _handle;
        public PfnRequestDeviceCallback
        (
            delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnRequestDeviceCallback
        (
             RequestDeviceCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRequestDeviceCallback From(RequestDeviceCallback proc) => new PfnRequestDeviceCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRequestDeviceCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRequestDeviceCallback(nint pfn)
            => new PfnRequestDeviceCallback((delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void>) pfn);

        public static implicit operator PfnRequestDeviceCallback(RequestDeviceCallback proc)
            => new PfnRequestDeviceCallback(proc);

        public static explicit operator RequestDeviceCallback(PfnRequestDeviceCallback pfn)
            => SilkMarshal.PtrToDelegate<RequestDeviceCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void>(PfnRequestDeviceCallback pfn) => pfn.Handle;
        public static implicit operator PfnRequestDeviceCallback(delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void> ptr) => new PfnRequestDeviceCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void RequestDeviceCallback(RequestDeviceStatus arg0, Device* arg1, byte* arg2, void* arg3);
}

