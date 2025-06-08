// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkValidationCacheHeaderVersionEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    VK_VALIDATION_CACHE_HEADER_VERSION_MAX_ENUM_EXT = 0x7FFFFFFF,
}
