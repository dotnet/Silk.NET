// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkShadingRatePaletteNV")]
    public unsafe partial struct ShadingRatePaletteNV
    {
        public ShadingRatePaletteNV
        (
            uint? shadingRatePaletteEntryCount = null,
            ShadingRatePaletteEntryNV* pShadingRatePaletteEntries = null
        ) : this()
        {
            if (shadingRatePaletteEntryCount is not null)
            {
                ShadingRatePaletteEntryCount = shadingRatePaletteEntryCount.Value;
            }

            if (pShadingRatePaletteEntries is not null)
            {
                PShadingRatePaletteEntries = pShadingRatePaletteEntries;
            }
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
