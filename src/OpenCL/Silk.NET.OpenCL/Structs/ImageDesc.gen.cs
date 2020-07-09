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

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_image_desc")]
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
        [NativeName("Type", "cl_mem_object_type")]
        [NativeName("Type.Name", "cl_mem_object_type")]
        [NativeName("Name", "image_type")]
        public uint ImageType;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_width")]
        public UIntPtr ImageWidth;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_height")]
        public UIntPtr ImageHeight;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_depth")]
        public UIntPtr ImageDepth;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_array_size")]
        public UIntPtr ImageArraySize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_row_pitch")]
        public UIntPtr ImageRowPitch;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_slice_pitch")]
        public UIntPtr ImageSlicePitch;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "num_mip_levels")]
        public uint NumMipLevels;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "num_samples")]
        public uint NumSamples;
    }
}
