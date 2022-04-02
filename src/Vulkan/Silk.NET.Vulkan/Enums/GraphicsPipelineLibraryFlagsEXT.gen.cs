// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkGraphicsPipelineLibraryFlagsEXT")]
    public enum GraphicsPipelineLibraryFlagsEXT : int
    {
        [NativeName("Name", "VK_GRAPHICS_PIPELINE_LIBRARY_VERTEX_INPUT_INTERFACE_BIT_EXT")]
        GraphicsPipelineLibraryVertexInputInterfaceBitExt = 1,
        [NativeName("Name", "VK_GRAPHICS_PIPELINE_LIBRARY_PRE_RASTERIZATION_SHADERS_BIT_EXT")]
        GraphicsPipelineLibraryPreRasterizationShadersBitExt = 2,
        [NativeName("Name", "VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_SHADER_BIT_EXT")]
        GraphicsPipelineLibraryFragmentShaderBitExt = 4,
        [NativeName("Name", "VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_OUTPUT_INTERFACE_BIT_EXT")]
        GraphicsPipelineLibraryFragmentOutputInterfaceBitExt = 8,
    }
}
