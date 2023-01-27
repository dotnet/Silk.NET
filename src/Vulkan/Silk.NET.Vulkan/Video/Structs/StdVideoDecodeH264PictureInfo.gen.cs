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
    [NativeName("Name", "StdVideoDecodeH264PictureInfo")]
    public unsafe partial struct StdVideoDecodeH264PictureInfo
    {
        public StdVideoDecodeH264PictureInfo
        (
            StdVideoDecodeH264PictureInfoFlags? flags = null,
            byte? seqParameterSetId = null,
            byte? picParameterSetId = null,
            byte? reserved1 = null,
            byte? reserved2 = null,
            ushort? frameNum = null,
            ushort? idrPicId = null
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

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (frameNum is not null)
            {
                FrameNum = frameNum.Value;
            }

            if (idrPicId is not null)
            {
                IdrPicId = idrPicId.Value;
            }
        }


        [NativeName("Type", "StdVideoDecodeH264PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeH264PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeH264PictureInfoFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_parameter_set_id")]
        public byte SeqParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pic_parameter_set_id")]
        public byte PicParameterSetId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved2")]
        public byte Reserved2;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "frame_num")]
        public ushort FrameNum;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "idr_pic_id")]
        public ushort IdrPicId;
        [NativeName("Type", "int32_t[2]")]
        [NativeName("Type.Name", "int32_t[2]")]
        [NativeName("Name", "PicOrderCnt")]
        public fixed int PicOrderCnt[2];
    }
}
