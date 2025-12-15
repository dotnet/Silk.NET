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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION")]
    public unsafe partial struct VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation
    {
        public VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation
        (
            byte? modificationOfPicNumsIdc = null,
            uint? absDiffPicNumMinus1 = null,
            uint? longTermPicNum = null
        ) : this()
        {
            if (modificationOfPicNumsIdc is not null)
            {
                ModificationOfPicNumsIdc = modificationOfPicNumsIdc.Value;
            }

            if (absDiffPicNumMinus1 is not null)
            {
                AbsDiffPicNumMinus1 = absDiffPicNumMinus1.Value;
            }

            if (longTermPicNum is not null)
            {
                LongTermPicNum = longTermPicNum.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "modification_of_pic_nums_idc")]
        public byte ModificationOfPicNumsIdc;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "abs_diff_pic_num_minus1")]
        public uint AbsDiffPicNumMinus1;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "long_term_pic_num")]
        public uint LongTermPicNum;
    }
}
