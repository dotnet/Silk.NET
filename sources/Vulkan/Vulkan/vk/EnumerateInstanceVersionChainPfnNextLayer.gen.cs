// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkEnumerateInstanceVersionChain_pfnNextLayer")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct EnumerateInstanceVersionChainPfnNextLayer : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [UnscopedRef]
    [SupportedApiProfile("vulkan")]
    public ref delegate* unmanaged<EnumerateInstanceVersionChain*, uint*, Result> Handle =>
        ref *(delegate* unmanaged<EnumerateInstanceVersionChain*, uint*, Result>*)Pointer;

    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceVersionChainPfnNextLayer(
        delegate* unmanaged<EnumerateInstanceVersionChain*, uint*, Result> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceVersionChainPfnNextLayer(
        EnumerateInstanceVersionChainPfnNextLayerDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator EnumerateInstanceVersionChainPfnNextLayer(
        delegate* unmanaged<EnumerateInstanceVersionChain*, uint*, Result> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<
        EnumerateInstanceVersionChain*,
        uint*,
        Result>(EnumerateInstanceVersionChainPfnNextLayer pfn) =>
        (delegate* unmanaged<EnumerateInstanceVersionChain*, uint*, Result>)pfn.Pointer;
}
