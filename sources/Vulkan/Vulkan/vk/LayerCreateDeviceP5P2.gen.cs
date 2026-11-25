// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkLayerCreateDevice_p5_p2")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct LayerCreateDeviceP5P2 : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan")]
    public delegate* unmanaged<void> Handle => (delegate* unmanaged<void>)Pointer;

    [SupportedApiProfile("vulkan")]
    public LayerCreateDeviceP5P2(delegate* unmanaged<void> ptr) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public LayerCreateDeviceP5P2(LayerCreateDeviceP5P2Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator LayerCreateDeviceP5P2(delegate* unmanaged<void> pfn) =>
        new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<void>(LayerCreateDeviceP5P2 pfn) =>
        (delegate* unmanaged<void>)pfn.Pointer;
}
