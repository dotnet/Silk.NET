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
    public unsafe readonly struct PfnAdapterRequestDeviceCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void>) _handle;
        public PfnAdapterRequestDeviceCallback
        (
            delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnAdapterRequestDeviceCallback
        (
             AdapterRequestDeviceCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnAdapterRequestDeviceCallback From(AdapterRequestDeviceCallback proc) => new PfnAdapterRequestDeviceCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnAdapterRequestDeviceCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnAdapterRequestDeviceCallback(nint pfn)
            => new PfnAdapterRequestDeviceCallback((delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void>) pfn);

        public static implicit operator PfnAdapterRequestDeviceCallback(AdapterRequestDeviceCallback proc)
            => new PfnAdapterRequestDeviceCallback(proc);

        public static explicit operator AdapterRequestDeviceCallback(PfnAdapterRequestDeviceCallback pfn)
            => SilkMarshal.PtrToDelegate<AdapterRequestDeviceCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void>(PfnAdapterRequestDeviceCallback pfn) => pfn.Handle;
        public static implicit operator PfnAdapterRequestDeviceCallback(delegate* unmanaged[Cdecl]<RequestDeviceStatus, Device*, byte*, void*, void> ptr) => new PfnAdapterRequestDeviceCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void AdapterRequestDeviceCallback(RequestDeviceStatus arg0, Device* arg1, byte* arg2, void* arg3);
}

