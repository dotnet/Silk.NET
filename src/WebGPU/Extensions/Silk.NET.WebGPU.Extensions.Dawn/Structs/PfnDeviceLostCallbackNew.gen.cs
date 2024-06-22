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
    public unsafe readonly struct PfnDeviceLostCallbackNew : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Device**, DeviceLostReason, byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<Device**, DeviceLostReason, byte*, void*, void>) _handle;
        public PfnDeviceLostCallbackNew
        (
            delegate* unmanaged[Cdecl]<Device**, DeviceLostReason, byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnDeviceLostCallbackNew
        (
             DeviceLostCallbackNew proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDeviceLostCallbackNew From(DeviceLostCallbackNew proc) => new PfnDeviceLostCallbackNew(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDeviceLostCallbackNew pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDeviceLostCallbackNew(nint pfn)
            => new PfnDeviceLostCallbackNew((delegate* unmanaged[Cdecl]<Device**, DeviceLostReason, byte*, void*, void>) pfn);

        public static implicit operator PfnDeviceLostCallbackNew(DeviceLostCallbackNew proc)
            => new PfnDeviceLostCallbackNew(proc);

        public static explicit operator DeviceLostCallbackNew(PfnDeviceLostCallbackNew pfn)
            => SilkMarshal.PtrToDelegate<DeviceLostCallbackNew>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Device**, DeviceLostReason, byte*, void*, void>(PfnDeviceLostCallbackNew pfn) => pfn.Handle;
        public static implicit operator PfnDeviceLostCallbackNew(delegate* unmanaged[Cdecl]<Device**, DeviceLostReason, byte*, void*, void> ptr) => new PfnDeviceLostCallbackNew(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DeviceLostCallbackNew(Device** arg0, DeviceLostReason arg1, byte* arg2, void* arg3);
}

