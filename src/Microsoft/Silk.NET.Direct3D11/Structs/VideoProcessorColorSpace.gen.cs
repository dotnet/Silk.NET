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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_COLOR_SPACE")]
    public unsafe partial struct VideoProcessorColorSpace
    {
        public VideoProcessorColorSpace
        (
            uint usage = default,
            uint rGBRange = default,
            uint yCbCrMatrix = default,
            uint yCbCrXvYCC = default,
            uint nominalRange = default,
            uint reserved = default
        )
        {
            Usage = usage;
            RGBRange = rGBRange;
            YCbCrMatrix = yCbCrMatrix;
            YCbCrXvYCC = yCbCrXvYCC;
            NominalRange = nominalRange;
            Reserved = reserved;
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
