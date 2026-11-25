// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkEnumerateInstanceLayerPropertiesChain")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct EnumerateInstanceLayerPropertiesChain
{
    [NativeName("header")]
    [SupportedApiProfile("vulkan")]
    public ChainHeader Header;

    [NativeName("pfnNextLayer")]
    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceLayerPropertiesChainPfnNextLayer PfnNextLayer;

    [NativeName("pNextLink")]
    [SupportedApiProfile("vulkan")]
    public EnumerateInstanceLayerPropertiesChain* PNextLink;

    [NativeName("CallDown")]
    [SupportedApiProfile("vulkan")]
    public readonly Result CallDown(uint* pPropertyCount, LayerProperties* pProperties)
    {
        return PfnNextLayer.Handle(PNextLink, pPropertyCount, pProperties);
    }
}
