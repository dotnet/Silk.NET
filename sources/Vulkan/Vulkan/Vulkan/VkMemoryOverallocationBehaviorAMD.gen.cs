// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "AMD")]
[NativeName("VkMemoryOverallocationBehaviorAMD")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkMemoryOverallocationBehaviorAMD : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VkMemoryOverallocationBehaviorDefault = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VkMemoryOverallocationBehaviorAllowed = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VkMemoryOverallocationBehaviorDisallowed = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_MEMORY_OVERALLOCATION_BEHAVIOR_MAX_ENUM_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_memory_overallocation_behavior"])]
    VkMemoryOverallocationBehaviorMaxEnum = 0x7FFFFFFF,
}
