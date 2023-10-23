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
            StdVideoH265PictureType? picType = null,
            byte? spsVideoParameterSetId = null,
            byte? ppsSeqParameterSetId = null,
            byte? ppsPicParameterSetId = null,
            byte? shortTermRefPicSetIdx = null,
            int? picOrderCntVal = null,
            byte? temporalId = null,
            StdVideoEncodeH265ReferenceListsInfo* pRefLists = null,
            StdVideoH265ShortTermRefPicSet* pShortTermRefPicSet = null,
            StdVideoEncodeH265LongTermRefPics* pLongTermRefPics = null
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

            if (shortTermRefPicSetIdx is not null)
            {
                ShortTermRefPicSetIdx = shortTermRefPicSetIdx.Value;
            }

            if (picOrderCntVal is not null)
            {
                PicOrderCntVal = picOrderCntVal.Value;
            }

            if (temporalId is not null)
            {
                TemporalId = temporalId.Value;
            }

            if (pRefLists is not null)
            {
                PRefLists = pRefLists;
            }

            if (pShortTermRefPicSet is not null)
            {
                PShortTermRefPicSet = pShortTermRefPicSet;
            }

            if (pLongTermRefPics is not null)
            {
                PLongTermRefPics = pLongTermRefPics;
            }
        }


        [NativeName("Type", "StdVideoEncodeH265PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265PictureInfoFlags Flags;

        [NativeName("Type", "StdVideoH265PictureType")]
        [NativeName("Type.Name", "StdVideoH265PictureType")]
        [NativeName("Name", "pic_type")]
        public StdVideoH265PictureType PicType;

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
        [NativeName("Name", "short_term_ref_pic_set_idx")]
        public byte ShortTermRefPicSetIdx;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCntVal")]
        public int PicOrderCntVal;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "TemporalId")]
        public byte TemporalId;
        [NativeName("Type", "uint8_t[7]")]
        [NativeName("Type.Name", "uint8_t[7]")]
        [NativeName("Name", "reserved1")]
        public fixed byte Reserved1[7];

        [NativeName("Type", "const StdVideoEncodeH265ReferenceListsInfo *")]
        [NativeName("Type.Name", "const StdVideoEncodeH265ReferenceListsInfo *")]
        [NativeName("Name", "pRefLists")]
        public StdVideoEncodeH265ReferenceListsInfo* PRefLists;

        [NativeName("Type", "const StdVideoH265ShortTermRefPicSet *")]
        [NativeName("Type.Name", "const StdVideoH265ShortTermRefPicSet *")]
        [NativeName("Name", "pShortTermRefPicSet")]
        public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

        [NativeName("Type", "const StdVideoEncodeH265LongTermRefPics *")]
        [NativeName("Type.Name", "const StdVideoEncodeH265LongTermRefPics *")]
        [NativeName("Name", "pLongTermRefPics")]
        public StdVideoEncodeH265LongTermRefPics* PLongTermRefPics;
    }
}
