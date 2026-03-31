// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "AMD")]
[NativeName("VkShaderInfoTypeAMD")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkShaderInfoTypeAMD : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_SHADER_INFO_TYPE_STATISTICS_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VkShaderInfoTypeStatistics = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_SHADER_INFO_TYPE_BINARY_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VkShaderInfoTypeBinary = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VkShaderInfoTypeDisassembly = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_SHADER_INFO_TYPE_MAX_ENUM_AMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    VkShaderInfoTypeMaxEnum = 0x7FFFFFFF,
}
