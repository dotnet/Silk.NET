// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkValidationCheckEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    VK_VALIDATION_CHECK_ALL_EXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    VK_VALIDATION_CHECK_SHADERS_EXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    VK_VALIDATION_CHECK_MAX_ENUM_EXT = 0x7FFFFFFF,
}
