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

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_image_format")]
    public unsafe partial struct ImageFormat
    {
        public ImageFormat
        (
            ChannelOrder? imageChannelOrder = null,
            ChannelType? imageChannelDataType = null
        ) : this()
        {
            if (imageChannelOrder is not null)
            {
                ImageChannelOrder = imageChannelOrder.Value;
            }

            if (imageChannelDataType is not null)
            {
                ImageChannelDataType = imageChannelDataType.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_channel_order")]
        [NativeName("Type.Name", "cl_channel_order")]
        [NativeName("Name", "image_channel_order")]
        public ChannelOrder ImageChannelOrder;
/// <summary></summary>
        [NativeName("Type", "cl_channel_type")]
        [NativeName("Type.Name", "cl_channel_type")]
        [NativeName("Name", "image_channel_data_type")]
        public ChannelType ImageChannelDataType;
    }
}
