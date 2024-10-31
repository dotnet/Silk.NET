// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            ShadingRatePaletteEntryNV? shadingRate = null,
            uint? sampleCount = null,
            uint? sampleLocationCount = null,
            CoarseSampleLocationNV* pSampleLocations = null
        ) : this()
        {
            if (shadingRate is not null)
            {
                ShadingRate = shadingRate.Value;
            }

            if (sampleCount is not null)
            {
                SampleCount = sampleCount.Value;
            }

            if (sampleLocationCount is not null)
            {
                SampleLocationCount = sampleLocationCount.Value;
            }

            if (pSampleLocations is not null)
            {
                PSampleLocations = pSampleLocations;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
