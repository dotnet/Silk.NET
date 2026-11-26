// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkEnumerateInstanceExtensionPropertiesChain_pfnNextLayer")]
[SupportedApiProfile("vulkan")]
public readonly unsafe struct EnumerateInstanceExtensionPropertiesChainPfnNextLayer : IDisposable
{
    [SupportedApiProfile("vulkan")]
    private readonly void* Pointer;

    [UnscopedRef]
    [SupportedApiProfile("vulkan")]
    public ref delegate* unmanaged<
        EnumerateInstanceExtensionPropertiesChain*,
        sbyte*,
        uint*,
        ExtensionProperties*,
        Result> Handle =>
        ref *(delegate* unmanaged<
            EnumerateInstanceExtensionPropertiesChain*,
            sbyte*,
            uint*,
            ExtensionProperties*,
            Result>*)Pointer;

    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceExtensionPropertiesChainPfnNextLayer(
        delegate* unmanaged<
            EnumerateInstanceExtensionPropertiesChain*,
            sbyte*,
            uint*,
            ExtensionProperties*,
            Result> ptr
    ) => Pointer = ptr;

    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceExtensionPropertiesChainPfnNextLayer(
        EnumerateInstanceExtensionPropertiesChainPfnNextLayerDelegate proc
    ) => Pointer = SilkMarshal.DelegateToPtr(proc);

    [SupportedApiProfile("vulkan")]
    public void Dispose() => SilkMarshal.Free(Pointer);

    [SupportedApiProfile("vulkan")]
    public static implicit operator EnumerateInstanceExtensionPropertiesChainPfnNextLayer(
        delegate* unmanaged<
            EnumerateInstanceExtensionPropertiesChain*,
            sbyte*,
            uint*,
            ExtensionProperties*,
            Result> pfn
    ) => new(pfn);

    [SupportedApiProfile("vulkan")]
    public static implicit operator delegate* unmanaged<
        EnumerateInstanceExtensionPropertiesChain*,
        sbyte*,
        uint*,
        ExtensionProperties*,
        Result>(EnumerateInstanceExtensionPropertiesChainPfnNextLayer pfn) =>
        (delegate* unmanaged<
            EnumerateInstanceExtensionPropertiesChain*,
            sbyte*,
            uint*,
            ExtensionProperties*,
            Result>)
            pfn.Pointer;
}
