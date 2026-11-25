// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_GetPhysicalDeviceProcAddr")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct PfnGetPhysicalDeviceProcAddr : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan")]
    public delegate* unmanaged<InstanceHandle, sbyte*, PfnGetPhysicalDeviceProcAddrP2> Handle =>
        (delegate* unmanaged<InstanceHandle, sbyte*, PfnGetPhysicalDeviceProcAddrP2>)Pointer;

    [SupportedApiProfile("vulkan")]
    public PfnGetPhysicalDeviceProcAddr(
        delegate* unmanaged<InstanceHandle, sbyte*, PfnGetPhysicalDeviceProcAddrP2> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public PfnGetPhysicalDeviceProcAddr(PfnGetPhysicalDeviceProcAddrDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator PfnGetPhysicalDeviceProcAddr(
        delegate* unmanaged<InstanceHandle, sbyte*, PfnGetPhysicalDeviceProcAddrP2> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<
        InstanceHandle,
        sbyte*,
        PfnGetPhysicalDeviceProcAddrP2>(PfnGetPhysicalDeviceProcAddr pfn) =>
        (delegate* unmanaged<InstanceHandle, sbyte*, PfnGetPhysicalDeviceProcAddrP2>)pfn.Pointer;
}
