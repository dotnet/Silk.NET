// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkLayerDestroyDevice")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct LayerDestroyDevice : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [UnscopedRef]
    [SupportedApiProfile("vulkan")]
    public ref delegate* unmanaged<
        DeviceHandle,
        AllocationCallbacks*,
        LayerDestroyDeviceP2,
        void> Handle =>
        ref *(delegate* unmanaged<
            DeviceHandle,
            AllocationCallbacks*,
            LayerDestroyDeviceP2,
            void>*)Pointer;

    [SupportedApiProfile("vulkan")]
    public LayerDestroyDevice(
        delegate* unmanaged<DeviceHandle, AllocationCallbacks*, LayerDestroyDeviceP2, void> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public LayerDestroyDevice(LayerDestroyDeviceDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator LayerDestroyDevice(
        delegate* unmanaged<DeviceHandle, AllocationCallbacks*, LayerDestroyDeviceP2, void> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<
        DeviceHandle,
        AllocationCallbacks*,
        LayerDestroyDeviceP2,
        void>(LayerDestroyDevice pfn) =>
        (delegate* unmanaged<DeviceHandle, AllocationCallbacks*, LayerDestroyDeviceP2, void>)
            pfn.Pointer;
}
