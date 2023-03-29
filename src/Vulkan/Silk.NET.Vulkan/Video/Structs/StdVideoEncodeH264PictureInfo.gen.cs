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
            ushort? reserved1 = null,
            StdVideoH264PictureType? pictureType = null,
            uint? frameNum = null,
            int? picOrderCnt = null
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

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (pictureType is not null)
            {
                PictureType = pictureType.Value;
            }

            if (frameNum is not null)
            {
                FrameNum = frameNum.Value;
            }

            if (picOrderCnt is not null)
            {
                PicOrderCnt = picOrderCnt.Value;
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
        [NativeName("Name", "reserved1")]
        public ushort Reserved1;

        [NativeName("Type", "StdVideoH264PictureType")]
        [NativeName("Type.Name", "StdVideoH264PictureType")]
        [NativeName("Name", "pictureType")]
        public StdVideoH264PictureType PictureType;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_num")]
        public uint FrameNum;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "PicOrderCnt")]
        public int PicOrderCnt;
    }
}
