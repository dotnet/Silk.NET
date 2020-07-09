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
    [NativeName("Name", "VkShadingRatePaletteNV")]
    public unsafe struct ShadingRatePaletteNV
    {
        public ShadingRatePaletteNV
        (
            uint shadingRatePaletteEntryCount = default,
            ShadingRatePaletteEntryNV* pShadingRatePaletteEntries = default
        )
        {
           ShadingRatePaletteEntryCount = shadingRatePaletteEntryCount;
           PShadingRatePaletteEntries = pShadingRatePaletteEntries;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shadingRatePaletteEntryCount")]
        public uint ShadingRatePaletteEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkShadingRatePaletteEntryNV*")]
        [NativeName("Type.Name", "VkShadingRatePaletteEntryNV")]
        [NativeName("Name", "pShadingRatePaletteEntries")]
        public ShadingRatePaletteEntryNV* PShadingRatePaletteEntries;
    }
}
