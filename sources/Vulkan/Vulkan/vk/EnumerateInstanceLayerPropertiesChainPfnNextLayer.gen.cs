// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkEnumerateInstanceLayerPropertiesChain_pfnNextLayer")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct EnumerateInstanceLayerPropertiesChainPfnNextLayer : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [SupportedApiProfile("vulkan")]
    public delegate* unmanaged<
        EnumerateInstanceLayerPropertiesChain*,
        uint*,
        LayerProperties*,
        Result> Handle =>
        (delegate* unmanaged<
            EnumerateInstanceLayerPropertiesChain*,
            uint*,
            LayerProperties*,
            Result>)Pointer;

    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceLayerPropertiesChainPfnNextLayer(
        delegate* unmanaged<
            EnumerateInstanceLayerPropertiesChain*,
            uint*,
            LayerProperties*,
            Result> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceLayerPropertiesChainPfnNextLayer(
        EnumerateInstanceLayerPropertiesChainPfnNextLayerDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator EnumerateInstanceLayerPropertiesChainPfnNextLayer(
        delegate* unmanaged<
            EnumerateInstanceLayerPropertiesChain*,
            uint*,
            LayerProperties*,
            Result> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<
        EnumerateInstanceLayerPropertiesChain*,
        uint*,
        LayerProperties*,
        Result>(EnumerateInstanceLayerPropertiesChainPfnNextLayer pfn) =>
        (delegate* unmanaged<
            EnumerateInstanceLayerPropertiesChain*,
            uint*,
            LayerProperties*,
            Result>)
            pfn.Pointer;
}
