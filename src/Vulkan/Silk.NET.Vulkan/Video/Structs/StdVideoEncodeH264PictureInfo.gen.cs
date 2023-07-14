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
    [NativeName("Name", "StdVideoEncodeH264PictureInfo")]
    public unsafe partial struct StdVideoEncodeH264PictureInfo
    {
        public StdVideoEncodeH264PictureInfo
        (
            StdVideoEncodeH264PictureInfoFlags? flags = null,
            byte? seqParameterSetId = null,
            byte? picParameterSetId = null,
            ushort? idrPicId = null,
            StdVideoH264PictureType? primaryPicType = null,
            uint? frameNum = null,
            int? picOrderCnt = null,
            byte? temporalId = null,
            StdVideoEncodeH264ReferenceListsInfo* pRefLists = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (seqParameterSetId is not null)
            {
                SeqParameterSetId = seqParameterSetId.Value;
            }

            if (picParameterSetId is not null)
            {
                PicParameterSetId = picParameterSetId.Value;
            }

            if (idrPicId is not null)
            {
                IdrPicId = idrPicId.Value;
            }

            if (primaryPicType is not null)
            {
                PrimaryPicType = primaryPicType.Value;
            }

            if (frameNum is not null)
            {
                FrameNum = frameNum.Value;
            }

            if (picOrderCnt is not null)
            {
                PicOrderCnt = picOrderCnt.Value;
            }

            if (temporalId is not null)
            {
                TemporalId = temporalId.Value;
            }

            if (pRefLists is not null)
            {
                PRefLists = pRefLists;
            }
        }


        [NativeName("Type", "StdVideoEncodeH264PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH264PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH264PictureInfoFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_parameter_set_id")]
        public byte SeqParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pic_parameter_set_id")]
        public byte PicParameterSetId;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "idr_pic_id")]
        public ushort IdrPicId;

        [NativeName("Type", "StdVideoH264PictureType")]
        [NativeName("Type.Name", "StdVideoH264PictureType")]
        [NativeName("Name", "primary_pic_type")]
        public StdVideoH264PictureType PrimaryPicType;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_num")]
        public uint FrameNum;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCnt")]
        public int PicOrderCnt;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "temporal_id")]
        public byte TemporalId;
        [NativeName("Type", "uint8_t[3]")]
        [NativeName("Type.Name", "uint8_t[3]")]
        [NativeName("Name", "reserved1")]
        public fixed byte Reserved1[3];

        [NativeName("Type", "const StdVideoEncodeH264ReferenceListsInfo *")]
        [NativeName("Type.Name", "const StdVideoEncodeH264ReferenceListsInfo *")]
        [NativeName("Name", "pRefLists")]
        public StdVideoEncodeH264ReferenceListsInfo* PRefLists;
    }
}
