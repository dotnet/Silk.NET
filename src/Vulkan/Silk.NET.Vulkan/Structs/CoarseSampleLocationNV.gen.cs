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
    [NativeName("Name", "VkCoarseSampleLocationNV")]
    public unsafe partial struct CoarseSampleLocationNV
    {
        public CoarseSampleLocationNV
        (
            uint? pixelX = null,
            uint? pixelY = null,
            uint? sample = null
        ) : this()
        {
            if (pixelX is not null)
            {
                PixelX = pixelX.Value;
            }

            if (pixelY is not null)
            {
                PixelY = pixelY.Value;
            }

            if (sample is not null)
            {
                Sample = sample.Value;
            }
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
