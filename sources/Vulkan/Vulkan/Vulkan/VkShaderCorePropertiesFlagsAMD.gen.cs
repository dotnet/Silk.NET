// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkShaderCorePropertiesFlagsAMD
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_shader_core_properties2"],
        ImpliesSets = ["VK_AMD_shader_core_properties"]
    )]
    VK_SHADER_CORE_PROPERTIES_FLAG_BITS_MAX_ENUM_AMD = 0x7FFFFFFF,
}
