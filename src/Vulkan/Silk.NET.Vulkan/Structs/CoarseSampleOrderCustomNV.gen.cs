// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct CoarseSampleOrderCustomNV
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
        public ShadingRatePaletteEntryNV ShadingRate;
/// <summary></summary>
        public uint SampleCount;
/// <summary></summary>
        public uint SampleLocationCount;
/// <summary></summary>
        public CoarseSampleLocationNV* PSampleLocations;
    }
}
