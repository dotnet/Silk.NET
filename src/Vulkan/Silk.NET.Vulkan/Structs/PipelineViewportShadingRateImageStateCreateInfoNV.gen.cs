// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineViewportShadingRateImageStateCreateInfoNV
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ShadingRateImageEnable;
/// <summary></summary>
        public uint ViewportCount;
/// <summary></summary>
        public ShadingRatePaletteNV* PShadingRatePalettes;
    }
}
