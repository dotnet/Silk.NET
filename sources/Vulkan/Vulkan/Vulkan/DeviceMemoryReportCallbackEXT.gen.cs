// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public readonly unsafe struct DeviceMemoryReportCallbackEXT : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void> Handle =>
        (delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void>)Pointer;

    public DeviceMemoryReportCallbackEXT(
        delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void> ptr
    ) => Pointer = ptr;

    public DeviceMemoryReportCallbackEXT(DeviceMemoryReportCallbackEXTDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator DeviceMemoryReportCallbackEXT(
        delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<
        DeviceMemoryReportCallbackDataEXT*,
        void*,
        void>(DeviceMemoryReportCallbackEXT pfn) =>
        (delegate* unmanaged<DeviceMemoryReportCallbackDataEXT*, void*, void>)pfn.Pointer;
}
