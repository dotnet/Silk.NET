// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderLongVectorPropertiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderLongVectorPropertiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_long_vector"], ImpliesSets = ["VK_VERSION_1_2"])]
    public StructureType SType = StructureType.PhysicalDeviceShaderLongVectorPropertiesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_long_vector"], ImpliesSets = ["VK_VERSION_1_2"])]
    public void* PNext;

    [NativeName("maxVectorComponents")]
    [SupportedApiProfile("vulkan", ["VK_EXT_shader_long_vector"], ImpliesSets = ["VK_VERSION_1_2"])]
    public uint MaxVectorComponents;

    [SupportedApiProfile("vulkan", ["VK_EXT_shader_long_vector"], ImpliesSets = ["VK_VERSION_1_2"])]
    public PhysicalDeviceShaderLongVectorPropertiesEXT() { }
}
