// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public readonly unsafe struct GetInstanceProcAddrLunargP2 : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan")]
    public delegate* unmanaged<void> Handle => (delegate* unmanaged<void>)Pointer;

    [SupportedApiProfile("vulkan")]
    public GetInstanceProcAddrLunargP2(delegate* unmanaged<void> ptr) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public GetInstanceProcAddrLunargP2(GetInstanceProcAddrLunargP2Delegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator GetInstanceProcAddrLunargP2(delegate* unmanaged<void> pfn) =>
        new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<void>(GetInstanceProcAddrLunargP2 pfn) =>
        (delegate* unmanaged<void>)pfn.Pointer;
}
