// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkSetDeviceLoaderData")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct SetDeviceLoaderData : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan")]
    public delegate* unmanaged<DeviceHandle, void*, Result> Handle =>
        (delegate* unmanaged<DeviceHandle, void*, Result>)Pointer;

    [SupportedApiProfile("vulkan")]
    public SetDeviceLoaderData(delegate* unmanaged<DeviceHandle, void*, Result> ptr) =>
        Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public SetDeviceLoaderData(SetDeviceLoaderDataDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator SetDeviceLoaderData(
        delegate* unmanaged<DeviceHandle, void*, Result> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<DeviceHandle, void*, Result>(
        SetDeviceLoaderData pfn
    ) => (delegate* unmanaged<DeviceHandle, void*, Result>)pfn.Pointer;
}
