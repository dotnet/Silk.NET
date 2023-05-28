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

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "SpvReflectImageTraits")]
    public unsafe partial struct ImageTraits
    {
        public ImageTraits
        (
            Silk.NET.SPIRV.Dim? dim = null,
            uint? depth = null,
            uint? arrayed = null,
            uint? ms = null,
            uint? sampled = null,
            Silk.NET.SPIRV.ImageFormat? imageFormat = null
        ) : this()
        {
            if (dim is not null)
            {
                Dim = dim.Value;
            }

            if (depth is not null)
            {
                Depth = depth.Value;
            }

            if (arrayed is not null)
            {
                Arrayed = arrayed.Value;
            }

            if (ms is not null)
            {
                Ms = ms.Value;
            }

            if (sampled is not null)
            {
                Sampled = sampled.Value;
            }

            if (imageFormat is not null)
            {
                ImageFormat = imageFormat.Value;
            }
        }


        [NativeName("Type", "SpvDim")]
        [NativeName("Type.Name", "SpvDim")]
        [NativeName("Name", "dim")]
        public Silk.NET.SPIRV.Dim Dim;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "depth")]
        public uint Depth;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arrayed")]
        public uint Arrayed;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "ms")]
        public uint Ms;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampled")]
        public uint Sampled;

        [NativeName("Type", "SpvImageFormat")]
        [NativeName("Type.Name", "SpvImageFormat")]
        [NativeName("Name", "image_format")]
        public Silk.NET.SPIRV.ImageFormat ImageFormat;
    }
}
