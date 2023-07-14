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
    [NativeName("Name", "StdVideoEncodeH265ReferenceInfo")]
    public unsafe partial struct StdVideoEncodeH265ReferenceInfo
    {
        public StdVideoEncodeH265ReferenceInfo
        (
            StdVideoEncodeH265ReferenceInfoFlags? flags = null,
            StdVideoH265PictureType? picType = null,
            int? picOrderCntVal = null,
            byte? temporalId = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (picType is not null)
            {
                PicType = picType.Value;
            }

            if (picOrderCntVal is not null)
            {
                PicOrderCntVal = picOrderCntVal.Value;
            }

            if (temporalId is not null)
            {
                TemporalId = temporalId.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeH265ReferenceInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265ReferenceInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265ReferenceInfoFlags Flags;

        [NativeName("Type", "StdVideoH265PictureType")]
        [NativeName("Type.Name", "StdVideoH265PictureType")]
        [NativeName("Name", "pic_type")]
        public StdVideoH265PictureType PicType;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCntVal")]
        public int PicOrderCntVal;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "TemporalId")]
        public byte TemporalId;
    }
}
