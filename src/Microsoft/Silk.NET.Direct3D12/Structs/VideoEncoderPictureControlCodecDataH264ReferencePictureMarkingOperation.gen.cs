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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION")]
    public unsafe partial struct VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation
    {
        public VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation
        (
            byte? memoryManagementControlOperation = null,
            uint? differenceOfPicNumsMinus1 = null,
            uint? longTermPicNum = null,
            uint? longTermFrameIdx = null,
            uint? maxLongTermFrameIdxPlus1 = null
        ) : this()
        {
            if (memoryManagementControlOperation is not null)
            {
                MemoryManagementControlOperation = memoryManagementControlOperation.Value;
            }

            if (differenceOfPicNumsMinus1 is not null)
            {
                DifferenceOfPicNumsMinus1 = differenceOfPicNumsMinus1.Value;
            }

            if (longTermPicNum is not null)
            {
                LongTermPicNum = longTermPicNum.Value;
            }

            if (longTermFrameIdx is not null)
            {
                LongTermFrameIdx = longTermFrameIdx.Value;
            }

            if (maxLongTermFrameIdxPlus1 is not null)
            {
                MaxLongTermFrameIdxPlus1 = maxLongTermFrameIdxPlus1.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "memory_management_control_operation")]
        public byte MemoryManagementControlOperation;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "difference_of_pic_nums_minus1")]
        public uint DifferenceOfPicNumsMinus1;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "long_term_pic_num")]
        public uint LongTermPicNum;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "long_term_frame_idx")]
        public uint LongTermFrameIdx;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "max_long_term_frame_idx_plus1")]
        public uint MaxLongTermFrameIdxPlus1;
    }
}
