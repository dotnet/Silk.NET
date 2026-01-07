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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9ColorConfig")]
    public unsafe partial struct StdVideoVP9ColorConfig
    {
        public StdVideoVP9ColorConfig
        (
            StdVideoVP9ColorConfigFlags? flags = null,
            byte? bitDepth = null,
            byte? subsamplingX = null,
            byte? subsamplingY = null,
            byte? reserved1 = null,
            StdVideoVP9ColorSpace? colorSpace = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (bitDepth is not null)
            {
                BitDepth = bitDepth.Value;
            }

            if (subsamplingX is not null)
            {
                SubsamplingX = subsamplingX.Value;
            }

            if (subsamplingY is not null)
            {
                SubsamplingY = subsamplingY.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }
        }


        [NativeName("Type", "StdVideoVP9ColorConfigFlags")]
        [NativeName("Type.Name", "StdVideoVP9ColorConfigFlags")]
        [NativeName("Name", "flags")]
        public StdVideoVP9ColorConfigFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "BitDepth")]
        public byte BitDepth;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "subsampling_x")]
        public byte SubsamplingX;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "subsampling_y")]
        public byte SubsamplingY;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "StdVideoVP9ColorSpace")]
        [NativeName("Type.Name", "StdVideoVP9ColorSpace")]
        [NativeName("Name", "color_space")]
        public StdVideoVP9ColorSpace ColorSpace;
    }
}
