// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkValidationCacheCreateInfoEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkValidationCacheCreateInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkValidationCacheCreateFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public uint Flags;

    [NativeName("initialDataSize")]
    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public nuint InitialDataSize;

    [NativeName("pInitialData")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public void* PInitialData;
}
