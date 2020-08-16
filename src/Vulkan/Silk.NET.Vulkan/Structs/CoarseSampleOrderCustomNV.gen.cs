// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCoarseSampleOrderCustomNV")]
    public unsafe partial struct CoarseSampleOrderCustomNV
    {
        public CoarseSampleOrderCustomNV
        (
            ShadingRatePaletteEntryNV shadingRate = default,
            uint sampleCount = default,
            uint sampleLocationCount = default,
            CoarseSampleLocationNV* pSampleLocations = default
        )
        {
            ShadingRate = shadingRate;
            SampleCount = sampleCount;
            SampleLocationCount = sampleLocationCount;
            PSampleLocations = pSampleLocations;
        }

/// <summary></summary>
        [NativeName("Type", "VkShadingRatePaletteEntryNV")]
        [NativeName("Type.Name", "VkShadingRatePaletteEntryNV")]
        [NativeName("Name", "shadingRate")]
        public ShadingRatePaletteEntryNV ShadingRate;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampleCount")]
        public uint SampleCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampleLocationCount")]
        public uint SampleLocationCount;
/// <summary></summary>
        [NativeName("Type", "VkCoarseSampleLocationNV*")]
        [NativeName("Type.Name", "VkCoarseSampleLocationNV")]
        [NativeName("Name", "pSampleLocations")]
        public CoarseSampleLocationNV* PSampleLocations;
    }
}
