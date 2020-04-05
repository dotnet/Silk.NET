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
    public unsafe struct CoarseSampleLocationNV
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
        public uint PixelX;
/// <summary></summary>
        public uint PixelY;
/// <summary></summary>
        public uint Sample;
    }
}
