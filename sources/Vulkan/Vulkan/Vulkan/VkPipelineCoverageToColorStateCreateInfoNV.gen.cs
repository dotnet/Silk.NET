// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCoverageToColorStateCreateInfoNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkPipelineCoverageToColorStateCreateFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public uint Flags;

    [NativeName("coverageToColorEnable")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public uint CoverageToColorEnable;

    [NativeName("coverageToColorLocation")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public uint CoverageToColorLocation;
}
