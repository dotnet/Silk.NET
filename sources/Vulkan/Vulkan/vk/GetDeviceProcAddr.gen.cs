// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkGetDeviceProcAddr")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct GetDeviceProcAddr : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [UnscopedRef]
    [SupportedApiProfile("vulkan")]
    public ref delegate* unmanaged<DeviceHandle, sbyte*, GetDeviceProcAddrP2> Handle =>
        ref *(delegate* unmanaged<DeviceHandle, sbyte*, GetDeviceProcAddrP2>*)Pointer;

    [SupportedApiProfile("vulkan")]
    public GetDeviceProcAddr(delegate* unmanaged<DeviceHandle, sbyte*, GetDeviceProcAddrP2> ptr) =>
        Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public GetDeviceProcAddr(GetDeviceProcAddrDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator GetDeviceProcAddr(
        delegate* unmanaged<DeviceHandle, sbyte*, GetDeviceProcAddrP2> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<DeviceHandle, sbyte*, GetDeviceProcAddrP2>(
        GetDeviceProcAddr pfn
    ) => (delegate* unmanaged<DeviceHandle, sbyte*, GetDeviceProcAddrP2>)pfn.Pointer;
}
