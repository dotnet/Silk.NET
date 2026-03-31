// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "INTEL")]
[NativeName("VkPerformanceValueTypeINTEL")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPerformanceValueTypeINTEL : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceValueTypeUint32 = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceValueTypeUint64 = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceValueTypeFloat = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceValueTypeBool = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceValueTypeString = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_MAX_ENUM_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceValueTypeMaxEnum = 0x7FFFFFFF,
}
