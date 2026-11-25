// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkChainType")]
[SupportedApiProfile("vulkan")]
public enum ChainType : uint
{
    [NativeName("VK_CHAIN_TYPE_UNKNOWN")]
    [SupportedApiProfile("vulkan")]
    Unknown = 0,

    [NativeName("VK_CHAIN_TYPE_ENUMERATE_INSTANCE_EXTENSION_PROPERTIES")]
    [SupportedApiProfile("vulkan")]
    EnumerateInstanceExtensionProperties = 1,

    [NativeName("VK_CHAIN_TYPE_ENUMERATE_INSTANCE_LAYER_PROPERTIES")]
    [SupportedApiProfile("vulkan")]
    EnumerateInstanceLayerProperties = 2,

    [NativeName("VK_CHAIN_TYPE_ENUMERATE_INSTANCE_VERSION")]
    [SupportedApiProfile("vulkan")]
    EnumerateInstanceVersion = 3,
}
