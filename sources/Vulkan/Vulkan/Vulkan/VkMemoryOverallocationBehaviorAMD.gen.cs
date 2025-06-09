// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkMemoryOverallocationBehaviorAMD : uint
{
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = 0,

    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = 1,

    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = 2,

    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VK_MEMORY_OVERALLOCATION_BEHAVIOR_MAX_ENUM_AMD = 0x7FFFFFFF,
}
