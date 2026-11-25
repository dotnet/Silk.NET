// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkLayerCreateDevice")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct LayerCreateDevice : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan")]
    public delegate* unmanaged<
        InstanceHandle,
        PhysicalDeviceHandle,
        DeviceCreateInfo*,
        AllocationCallbacks*,
        DeviceHandle*,
        LayerCreateDeviceP5,
        LayerCreateDeviceP6*,
        Result> Handle =>
        (delegate* unmanaged<
            InstanceHandle,
            PhysicalDeviceHandle,
            DeviceCreateInfo*,
            AllocationCallbacks*,
            DeviceHandle*,
            LayerCreateDeviceP5,
            LayerCreateDeviceP6*,
            Result>)Pointer;

    [SupportedApiProfile("vulkan")]
    public LayerCreateDevice(
        delegate* unmanaged<
            InstanceHandle,
            PhysicalDeviceHandle,
            DeviceCreateInfo*,
            AllocationCallbacks*,
            DeviceHandle*,
            LayerCreateDeviceP5,
            LayerCreateDeviceP6*,
            Result> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public LayerCreateDevice(LayerCreateDeviceDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator LayerCreateDevice(
        delegate* unmanaged<
            InstanceHandle,
            PhysicalDeviceHandle,
            DeviceCreateInfo*,
            AllocationCallbacks*,
            DeviceHandle*,
            LayerCreateDeviceP5,
            LayerCreateDeviceP6*,
            Result> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<
        InstanceHandle,
        PhysicalDeviceHandle,
        DeviceCreateInfo*,
        AllocationCallbacks*,
        DeviceHandle*,
        LayerCreateDeviceP5,
        LayerCreateDeviceP6*,
        Result>(LayerCreateDevice pfn) =>
        (delegate* unmanaged<
            InstanceHandle,
            PhysicalDeviceHandle,
            DeviceCreateInfo*,
            AllocationCallbacks*,
            DeviceHandle*,
            LayerCreateDeviceP5,
            LayerCreateDeviceP6*,
            Result>)
            pfn.Pointer;
}
