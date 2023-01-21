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
    [NativeName("Name", "StdVideoDecodeH265PictureInfo")]
    public unsafe partial struct StdVideoDecodeH265PictureInfo
    {
        public StdVideoDecodeH265PictureInfo
        (
            StdVideoDecodeH265PictureInfoFlags? flags = null,
            byte? spsVideoParameterSetId = null,
            byte? ppsSeqParameterSetId = null,
            byte? ppsPicParameterSetId = null,
            byte? numDeltaPocsOfRefRpsIdx = null,
            int? picOrderCntVal = null,
            ushort? numBitsForSTRefPicSetInSlice = null,
            ushort? reserved = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
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

            if (numDeltaPocsOfRefRpsIdx is not null)
            {
                NumDeltaPocsOfRefRpsIdx = numDeltaPocsOfRefRpsIdx.Value;
            }

            if (picOrderCntVal is not null)
            {
                PicOrderCntVal = picOrderCntVal.Value;
            }

            if (numBitsForSTRefPicSetInSlice is not null)
            {
                NumBitsForSTRefPicSetInSlice = numBitsForSTRefPicSetInSlice.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "StdVideoDecodeH265PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeH265PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeH265PictureInfoFlags Flags;

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
        [NativeName("Name", "NumDeltaPocsOfRefRpsIdx")]
        public byte NumDeltaPocsOfRefRpsIdx;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCntVal")]
        public int PicOrderCntVal;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "NumBitsForSTRefPicSetInSlice")]
        public ushort NumBitsForSTRefPicSetInSlice;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "reserved")]
        public ushort Reserved;
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "RefPicSetStCurrBefore")]
        public fixed byte RefPicSetStCurrBefore[8];
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "RefPicSetStCurrAfter")]
        public fixed byte RefPicSetStCurrAfter[8];
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "RefPicSetLtCurr")]
        public fixed byte RefPicSetLtCurr[8];
    }
}
