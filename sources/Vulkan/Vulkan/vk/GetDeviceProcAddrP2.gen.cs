// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkGetDeviceProcAddr_p2")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct GetDeviceProcAddrP2 : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [UnscopedRef]
    [SupportedApiProfile("vulkan")]
    public ref delegate* unmanaged<void> Handle => ref *(delegate* unmanaged<void>*)Pointer;

    [SupportedApiProfile("vulkan")]
    public GetDeviceProcAddrP2(delegate* unmanaged<void> ptr) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public GetDeviceProcAddrP2(GetDeviceProcAddrP2Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator GetDeviceProcAddrP2(delegate* unmanaged<void> pfn) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<void>(GetDeviceProcAddrP2 pfn) =>
        (delegate* unmanaged<void>)pfn.Pointer;
}
