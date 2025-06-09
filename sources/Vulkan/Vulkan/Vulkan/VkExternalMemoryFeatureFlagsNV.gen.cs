// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkExternalMemoryFeatureFlagsNV : uint
{
    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_NV_external_memory_capabilities"])]
    VK_EXTERNAL_MEMORY_FEATURE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
