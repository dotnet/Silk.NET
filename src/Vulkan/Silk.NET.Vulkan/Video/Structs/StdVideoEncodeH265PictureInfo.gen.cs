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
    [NativeName("Name", "StdVideoEncodeH265PictureInfo")]
    public unsafe partial struct StdVideoEncodeH265PictureInfo
    {
        public StdVideoEncodeH265PictureInfo
        (
            StdVideoEncodeH265PictureInfoFlags? flags = null,
            StdVideoH265PictureType? pictureType = null,
            byte? spsVideoParameterSetId = null,
            byte? ppsSeqParameterSetId = null,
            byte? ppsPicParameterSetId = null,
            byte? temporalId = null,
            int? picOrderCntVal = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pictureType is not null)
            {
                PictureType = pictureType.Value;
            }

            if (spsVideoParameterSetId is not null)
            {
                SpsVideoParameterSetId = spsVideoParameterSetId.Value;
            }

            if (ppsSeqParameterSetId is not null)
            {
                PpsSeqParameterSetId = ppsSeqParameterSetId.Value;
            }

            if (ppsPicParameterSetId is not null)
            {
                PpsPicParameterSetId = ppsPicParameterSetId.Value;
            }

            if (temporalId is not null)
            {
                TemporalId = temporalId.Value;
            }

            if (picOrderCntVal is not null)
            {
                PicOrderCntVal = picOrderCntVal.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeH265PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265PictureInfoFlags Flags;

        [NativeName("Type", "StdVideoH265PictureType")]
        [NativeName("Type.Name", "StdVideoH265PictureType")]
        [NativeName("Name", "PictureType")]
        public StdVideoH265PictureType PictureType;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "sps_video_parameter_set_id")]
        public byte SpsVideoParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pps_seq_parameter_set_id")]
        public byte PpsSeqParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pps_pic_parameter_set_id")]
        public byte PpsPicParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "TemporalId")]
        public byte TemporalId;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCntVal")]
        public int PicOrderCntVal;
    }
}
