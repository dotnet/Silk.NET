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
            byte? vpsVideoParameterSetId = null,
            byte? spsSeqParameterSetId = null,
            byte? ppsPicParameterSetId = null,
            byte? numShortTermRefPicSets = null,
            int? picOrderCntVal = null,
            ushort? numBitsForSTRefPicSetInSlice = null,
            byte? numDeltaPocsOfRefRpsIdx = null,
            StdVideoDecodeH265PictureInfoFlags? flags = null
        ) : this()
        {
            if (vpsVideoParameterSetId is not null)
            {
                VpsVideoParameterSetId = vpsVideoParameterSetId.Value;
            }

            if (spsSeqParameterSetId is not null)
            {
                SpsSeqParameterSetId = spsSeqParameterSetId.Value;
            }

            if (ppsPicParameterSetId is not null)
            {
                PpsPicParameterSetId = ppsPicParameterSetId.Value;
            }

            if (numShortTermRefPicSets is not null)
            {
                NumShortTermRefPicSets = numShortTermRefPicSets.Value;
            }

            if (picOrderCntVal is not null)
            {
                PicOrderCntVal = picOrderCntVal.Value;
            }

            if (numBitsForSTRefPicSetInSlice is not null)
            {
                NumBitsForSTRefPicSetInSlice = numBitsForSTRefPicSetInSlice.Value;
            }

            if (numDeltaPocsOfRefRpsIdx is not null)
            {
                NumDeltaPocsOfRefRpsIdx = numDeltaPocsOfRefRpsIdx.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "vps_video_parameter_set_id")]
        public byte VpsVideoParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "sps_seq_parameter_set_id")]
        public byte SpsSeqParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pps_pic_parameter_set_id")]
        public byte PpsPicParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_short_term_ref_pic_sets")]
        public byte NumShortTermRefPicSets;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCntVal")]
        public int PicOrderCntVal;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "NumBitsForSTRefPicSetInSlice")]
        public ushort NumBitsForSTRefPicSetInSlice;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "NumDeltaPocsOfRefRpsIdx")]
        public byte NumDeltaPocsOfRefRpsIdx;
        [NativeName("Type", "uint8_t [8]")]
        [NativeName("Type.Name", "uint8_t [8]")]
        [NativeName("Name", "RefPicSetStCurrBefore")]
        public fixed byte RefPicSetStCurrBefore[8];
        [NativeName("Type", "uint8_t [8]")]
        [NativeName("Type.Name", "uint8_t [8]")]
        [NativeName("Name", "RefPicSetStCurrAfter")]
        public fixed byte RefPicSetStCurrAfter[8];
        [NativeName("Type", "uint8_t [8]")]
        [NativeName("Type.Name", "uint8_t [8]")]
        [NativeName("Name", "RefPicSetLtCurr")]
        public fixed byte RefPicSetLtCurr[8];

        [NativeName("Type", "StdVideoDecodeH265PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeH265PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeH265PictureInfoFlags Flags;
    }
}
