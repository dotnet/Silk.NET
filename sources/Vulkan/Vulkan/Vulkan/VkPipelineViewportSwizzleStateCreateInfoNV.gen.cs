// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineViewportSwizzleStateCreateInfoNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkPipelineViewportSwizzleStateCreateFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public uint Flags;

    [NativeName("viewportCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public uint ViewportCount;

    [NativeName("pViewportSwizzles")]
    [NativeTypeName("const VkViewportSwizzleNV *")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportSwizzleNV* PViewportSwizzles;
}
