// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkLayerDestroyDevice_p2")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct LayerDestroyDeviceP2 : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [UnscopedRef]
    [SupportedApiProfile("vulkan")]
    public ref delegate* unmanaged<DeviceHandle, AllocationCallbacks*, void> Handle =>
        ref *(delegate* unmanaged<DeviceHandle, AllocationCallbacks*, void>*)Pointer;

    [SupportedApiProfile("vulkan")]
    public LayerDestroyDeviceP2(
        delegate* unmanaged<DeviceHandle, AllocationCallbacks*, void> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public LayerDestroyDeviceP2(LayerDestroyDeviceP2Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator LayerDestroyDeviceP2(
        delegate* unmanaged<DeviceHandle, AllocationCallbacks*, void> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<DeviceHandle, AllocationCallbacks*, void>(
        LayerDestroyDeviceP2 pfn
    ) => (delegate* unmanaged<DeviceHandle, AllocationCallbacks*, void>)pfn.Pointer;
}
