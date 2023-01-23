// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnDeviceMemoryReportCallbackEXT : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void> Handle =>
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void>) _handle;

        public PfnDeviceMemoryReportCallbackEXT
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void> ptr) => _handle = ptr;

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator nint(PfnDeviceMemoryReportCallbackEXT pfn) => (nint) pfn.Handle;

        public PfnDeviceMemoryReportCallbackEXT
            (DeviceMemoryReportCallbackEXT func) => _handle =
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void>) SilkMarshal.DelegateToPtr
                (func);

        public static implicit operator delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void>
            (PfnDeviceMemoryReportCallbackEXT pfn) => pfn.Handle;

        public static implicit operator PfnDeviceMemoryReportCallbackEXT
            (delegate* unmanaged[Cdecl]<DeviceMemoryReportCallbackDataEXT*, void*, void> func) => new(func);

        public static implicit operator PfnDeviceMemoryReportCallbackEXT
            (DeviceMemoryReportCallbackEXT func) => new(func);

        public static explicit operator DeviceMemoryReportCallbackEXT
            (PfnDeviceMemoryReportCallbackEXT pfn) => SilkMarshal.PtrToDelegate<DeviceMemoryReportCallbackEXT>
            ((nint) pfn.Handle);
    }
}
