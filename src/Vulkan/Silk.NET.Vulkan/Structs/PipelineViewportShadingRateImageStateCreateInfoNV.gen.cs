// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineViewportShadingRateImageStateCreateInfoNV")]
    public unsafe partial struct PipelineViewportShadingRateImageStateCreateInfoNV
    {
        public PipelineViewportShadingRateImageStateCreateInfoNV
        (
            StructureType sType = StructureType.PipelineViewportShadingRateImageStateCreateInfoNV,
            void* pNext = default,
            Bool32 shadingRateImageEnable = default,
            uint viewportCount = default,
            ShadingRatePaletteNV* pShadingRatePalettes = default
        )
        {
            SType = sType;
            PNext = pNext;
            ShadingRateImageEnable = shadingRateImageEnable;
            ViewportCount = viewportCount;
            PShadingRatePalettes = pShadingRatePalettes;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shadingRateImageEnable")]
        public Bool32 ShadingRateImageEnable;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewportCount")]
        public uint ViewportCount;
/// <summary></summary>
        [NativeName("Type", "VkShadingRatePaletteNV*")]
        [NativeName("Type.Name", "VkShadingRatePaletteNV")]
        [NativeName("Name", "pShadingRatePalettes")]
        public ShadingRatePaletteNV* PShadingRatePalettes;
    }
}
