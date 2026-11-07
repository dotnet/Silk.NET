// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGraphicsPipelineLibraryFlagsEXT")]
[Flags]
public enum GraphicsPipelineLibraryFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_GRAPHICS_PIPELINE_LIBRARY_VERTEX_INPUT_INTERFACE_BIT_EXT")]
    VertexInputInterfaceBit = 0x1,

    [NativeName("VK_GRAPHICS_PIPELINE_LIBRARY_PRE_RASTERIZATION_SHADERS_BIT_EXT")]
    PreRasterizationShadersBit = 0x2,

    [NativeName("VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_SHADER_BIT_EXT")]
    FragmentShaderBit = 0x4,

    [NativeName("VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_OUTPUT_INTERFACE_BIT_EXT")]
    FragmentOutputInterfaceBit = 0x8,
}
