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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_COLOR_SPACE")]
    public unsafe partial struct VideoProcessorColorSpace
    {
        public VideoProcessorColorSpace
        (
            uint? usage = null,
            uint? rGBRange = null,
            uint? yCbCrMatrix = null,
            uint? yCbCrXvYCC = null,
            uint? nominalRange = null,
            uint? reserved = null
        ) : this()
        {
            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (rGBRange is not null)
            {
                RGBRange = rGBRange.Value;
            }

            if (yCbCrMatrix is not null)
            {
                YCbCrMatrix = yCbCrMatrix.Value;
            }

            if (yCbCrXvYCC is not null)
            {
                YCbCrXvYCC = yCbCrXvYCC.Value;
            }

            if (nominalRange is not null)
            {
                NominalRange = nominalRange.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Usage")]
        public uint Usage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RGB_Range")]
        public uint RGBRange;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "YCbCr_Matrix")]
        public uint YCbCrMatrix;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "YCbCr_xvYCC")]
        public uint YCbCrXvYCC;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Nominal_Range")]
        public uint NominalRange;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Reserved")]
        public uint Reserved;
    }
}
