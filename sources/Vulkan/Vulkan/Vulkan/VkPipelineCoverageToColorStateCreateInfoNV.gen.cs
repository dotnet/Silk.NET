// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public void* pNext;

    [NativeTypeName("VkPipelineCoverageToColorStateCreateFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public uint flags;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public uint coverageToColorEnable;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_fragment_coverage_to_color"])]
    public uint coverageToColorLocation;
}
