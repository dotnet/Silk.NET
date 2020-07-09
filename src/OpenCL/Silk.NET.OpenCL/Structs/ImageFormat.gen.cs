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
    [NativeName("Name", "cl_image_format")]
    public unsafe struct ImageFormat
    {
        public ImageFormat
        (
            uint imageChannelOrder = default,
            uint imageChannelDataType = default
        )
        {
           ImageChannelOrder = imageChannelOrder;
           ImageChannelDataType = imageChannelDataType;
        }

/// <summary></summary>
        [NativeName("Type", "cl_channel_order")]
        [NativeName("Type.Name", "cl_channel_order")]
        [NativeName("Name", "image_channel_order")]
        public uint ImageChannelOrder;
/// <summary></summary>
        [NativeName("Type", "cl_channel_type")]
        [NativeName("Type.Name", "cl_channel_type")]
        [NativeName("Name", "image_channel_data_type")]
        public uint ImageChannelDataType;
    }
}
