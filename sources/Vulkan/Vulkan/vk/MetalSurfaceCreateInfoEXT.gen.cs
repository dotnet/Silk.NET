// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMetalSurfaceCreateInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct MetalSurfaceCreateInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public StructureType SType = StructureType.MetalSurfaceCreateInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public uint Flags;

    [NativeName("pLayer")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* PLayer;

    [SupportedApiProfile("vulkan", ["VK_EXT_metal_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public MetalSurfaceCreateInfoEXT() { }
}
