// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkShaderInfoTypeAMD
{
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VK_SHADER_INFO_TYPE_STATISTICS_AMD = 0,

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VK_SHADER_INFO_TYPE_BINARY_AMD = 1,

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD = 2,

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VK_SHADER_INFO_TYPE_MAX_ENUM_AMD = 0x7FFFFFFF,
}
