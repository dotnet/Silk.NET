// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkEnumerateInstanceExtensionPropertiesChain")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct EnumerateInstanceExtensionPropertiesChain
{
    [NativeName("header")]
    [SupportedApiProfile("vulkan")]
    public ChainHeader Header;

    [NativeName("pfnNextLayer")]
    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceExtensionPropertiesChainPfnNextLayer PfnNextLayer;

    [NativeName("pNextLink")]
    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceExtensionPropertiesChain* PNextLink;

    [NativeName("CallDown")]
    [SupportedApiProfile("vulkan")]
    public readonly Result CallDown(
        sbyte* pLayerName,
        uint* pPropertyCount,
        ExtensionProperties* pProperties
    )
    {
        return PfnNextLayer.Handle(PNextLink, pLayerName, pPropertyCount, pProperties);
    }
}
