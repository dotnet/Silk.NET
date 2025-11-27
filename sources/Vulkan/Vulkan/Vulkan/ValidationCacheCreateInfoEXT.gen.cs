// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("EXT", 0)]
[NativeName("VkValidationCacheCreateInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ValidationCacheCreateInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public uint Flags;

    [NativeName("initialDataSize")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public nuint InitialDataSize;

    [NativeName("pInitialData")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public void* PInitialData;
}
