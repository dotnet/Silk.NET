// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    public unsafe struct ImageDesc
    {
        public ImageDesc
        (
            uint imageType = default,
            UIntPtr imageWidth = default,
            UIntPtr imageHeight = default,
            UIntPtr imageDepth = default,
            UIntPtr imageArraySize = default,
            UIntPtr imageRowPitch = default,
            UIntPtr imageSlicePitch = default,
            uint numMipLevels = default,
            uint numSamples = default
        )
        {
           ImageType = imageType;
           ImageWidth = imageWidth;
           ImageHeight = imageHeight;
           ImageDepth = imageDepth;
           ImageArraySize = imageArraySize;
           ImageRowPitch = imageRowPitch;
           ImageSlicePitch = imageSlicePitch;
           NumMipLevels = numMipLevels;
           NumSamples = numSamples;
        }

/// <summary></summary>
        public uint ImageType;
/// <summary></summary>
        public UIntPtr ImageWidth;
/// <summary></summary>
        public UIntPtr ImageHeight;
/// <summary></summary>
        public UIntPtr ImageDepth;
/// <summary></summary>
        public UIntPtr ImageArraySize;
/// <summary></summary>
        public UIntPtr ImageRowPitch;
/// <summary></summary>
        public UIntPtr ImageSlicePitch;
/// <summary></summary>
        public uint NumMipLevels;
/// <summary></summary>
        public uint NumSamples;
    }
}
