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

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_image_desc")]
    public unsafe partial struct ImageDesc
    {
        public ImageDesc
        (
            uint? imageType = null,
            nuint? imageWidth = null,
            nuint? imageHeight = null,
            nuint? imageDepth = null,
            nuint? imageArraySize = null,
            nuint? imageRowPitch = null,
            nuint? imageSlicePitch = null,
            uint? numMipLevels = null,
            uint? numSamples = null
        ) : this()
        {
            if (imageType is not null)
            {
                ImageType = imageType.Value;
            }

            if (imageWidth is not null)
            {
                ImageWidth = imageWidth.Value;
            }

            if (imageHeight is not null)
            {
                ImageHeight = imageHeight.Value;
            }

            if (imageDepth is not null)
            {
                ImageDepth = imageDepth.Value;
            }

            if (imageArraySize is not null)
            {
                ImageArraySize = imageArraySize.Value;
            }

            if (imageRowPitch is not null)
            {
                ImageRowPitch = imageRowPitch.Value;
            }

            if (imageSlicePitch is not null)
            {
                ImageSlicePitch = imageSlicePitch.Value;
            }

            if (numMipLevels is not null)
            {
                NumMipLevels = numMipLevels.Value;
            }

            if (numSamples is not null)
            {
                NumSamples = numSamples.Value;
            }
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
        public nuint ImageWidth;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_height")]
        public nuint ImageHeight;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_depth")]
        public nuint ImageDepth;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_array_size")]
        public nuint ImageArraySize;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_row_pitch")]
        public nuint ImageRowPitch;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "image_slice_pitch")]
        public nuint ImageSlicePitch;
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
