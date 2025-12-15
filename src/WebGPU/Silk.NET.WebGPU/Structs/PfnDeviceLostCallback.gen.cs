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
    public unsafe readonly struct PfnDeviceLostCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DeviceLostReason, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<DeviceLostReason, byte*, void*, void>) _handle;
        public PfnDeviceLostCallback
        (
            delegate* unmanaged[Cdecl]<DeviceLostReason, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnDeviceLostCallback
        (
             DeviceLostCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDeviceLostCallback From(DeviceLostCallback proc) => new PfnDeviceLostCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDeviceLostCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDeviceLostCallback(nint pfn)
            => new PfnDeviceLostCallback((delegate* unmanaged[Cdecl]<DeviceLostReason, byte*, void*, void>) pfn);

        public static implicit operator PfnDeviceLostCallback(DeviceLostCallback proc)
            => new PfnDeviceLostCallback(proc);

        public static explicit operator DeviceLostCallback(PfnDeviceLostCallback pfn)
            => SilkMarshal.PtrToDelegate<DeviceLostCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DeviceLostReason, byte*, void*, void>(PfnDeviceLostCallback pfn) => pfn.Handle;
        public static implicit operator PfnDeviceLostCallback(delegate* unmanaged[Cdecl]<DeviceLostReason, byte*, void*, void> ptr) => new PfnDeviceLostCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DeviceLostCallback(DeviceLostReason arg0, byte* arg1, void* arg2);
}

