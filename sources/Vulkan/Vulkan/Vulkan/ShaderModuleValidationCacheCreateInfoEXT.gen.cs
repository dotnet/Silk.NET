// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ShaderModuleValidationCacheCreateInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public void* PNext;

    [NativeTypeName("VkValidationCacheEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    public ValidationCacheEXTHandle ValidationCache;
}
