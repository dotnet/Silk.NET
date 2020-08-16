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
    [NativeName("Name", "VkCoarseSampleLocationNV")]
    public unsafe partial struct CoarseSampleLocationNV
    {
        public CoarseSampleLocationNV
        (
            uint pixelX = default,
            uint pixelY = default,
            uint sample = default
        )
        {
            PixelX = pixelX;
            PixelY = pixelY;
            Sample = sample;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pixelX")]
        public uint PixelX;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pixelY")]
        public uint PixelY;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sample")]
        public uint Sample;
    }
}
