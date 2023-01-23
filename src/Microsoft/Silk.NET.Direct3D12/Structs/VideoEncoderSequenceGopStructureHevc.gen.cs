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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC")]
    public unsafe partial struct VideoEncoderSequenceGopStructureHevc
    {
        public VideoEncoderSequenceGopStructureHevc
        (
            uint? gOPLength = null,
            uint? pPicturePeriod = null,
            byte? log2MaxPicOrderCntLsbMinus4 = null
        ) : this()
        {
            if (gOPLength is not null)
            {
                GOPLength = gOPLength.Value;
            }

            if (pPicturePeriod is not null)
            {
                PPicturePeriod = pPicturePeriod.Value;
            }

            if (log2MaxPicOrderCntLsbMinus4 is not null)
            {
                Log2MaxPicOrderCntLsbMinus4 = log2MaxPicOrderCntLsbMinus4.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "GOPLength")]
        public uint GOPLength;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PPicturePeriod")]
        public uint PPicturePeriod;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "log2_max_pic_order_cnt_lsb_minus4")]
        public byte Log2MaxPicOrderCntLsbMinus4;
    }
}
