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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L6919_C5")]
    public unsafe partial struct VideoEncoderRateControlConfigurationParamsUnion
    {
        public VideoEncoderRateControlConfigurationParamsUnion
        (
            VideoEncoderRateControlCqp* pConfigurationCQP = null,
            VideoEncoderRateControlCbr* pConfigurationCBR = null,
            VideoEncoderRateControlVbr* pConfigurationVBR = null,
            VideoEncoderRateControlQvbr* pConfigurationQVBR = null,
            VideoEncoderRateControlCqp1* pConfigurationCQP1 = null,
            VideoEncoderRateControlCbr1* pConfigurationCBR1 = null,
            VideoEncoderRateControlVbr1* pConfigurationVBR1 = null,
            VideoEncoderRateControlQvbr1* pConfigurationQVBR1 = null,
            VideoEncoderRateControlAbsoluteQPMap* pConfigurationAbsoluteQPMap = null
        ) : this()
        {
            if (pConfigurationCQP is not null)
            {
                PConfigurationCQP = pConfigurationCQP;
            }

            if (pConfigurationCBR is not null)
            {
                PConfigurationCBR = pConfigurationCBR;
            }

            if (pConfigurationVBR is not null)
            {
                PConfigurationVBR = pConfigurationVBR;
            }

            if (pConfigurationQVBR is not null)
            {
                PConfigurationQVBR = pConfigurationQVBR;
            }

            if (pConfigurationCQP1 is not null)
            {
                PConfigurationCQP1 = pConfigurationCQP1;
            }

            if (pConfigurationCBR1 is not null)
            {
                PConfigurationCBR1 = pConfigurationCBR1;
            }

            if (pConfigurationVBR1 is not null)
            {
                PConfigurationVBR1 = pConfigurationVBR1;
            }

            if (pConfigurationQVBR1 is not null)
            {
                PConfigurationQVBR1 = pConfigurationQVBR1;
            }

            if (pConfigurationAbsoluteQPMap is not null)
            {
                PConfigurationAbsoluteQPMap = pConfigurationAbsoluteQPMap;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP *")]
        [NativeName("Name", "pConfiguration_CQP")]
        public VideoEncoderRateControlCqp* PConfigurationCQP;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR *")]
        [NativeName("Name", "pConfiguration_CBR")]
        public VideoEncoderRateControlCbr* PConfigurationCBR;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR *")]
        [NativeName("Name", "pConfiguration_VBR")]
        public VideoEncoderRateControlVbr* PConfigurationVBR;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR *")]
        [NativeName("Name", "pConfiguration_QVBR")]
        public VideoEncoderRateControlQvbr* PConfigurationQVBR;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1 *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1 *")]
        [NativeName("Name", "pConfiguration_CQP1")]
        public VideoEncoderRateControlCqp1* PConfigurationCQP1;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR1 *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR1 *")]
        [NativeName("Name", "pConfiguration_CBR1")]
        public VideoEncoderRateControlCbr1* PConfigurationCBR1;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR1 *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR1 *")]
        [NativeName("Name", "pConfiguration_VBR1")]
        public VideoEncoderRateControlVbr1* PConfigurationVBR1;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1 *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1 *")]
        [NativeName("Name", "pConfiguration_QVBR1")]
        public VideoEncoderRateControlQvbr1* PConfigurationQVBR1;

        [FieldOffset(0)]
        [NativeName("Type", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP *")]
        [NativeName("Name", "pConfiguration_AbsoluteQPMap")]
        public VideoEncoderRateControlAbsoluteQPMap* PConfigurationAbsoluteQPMap;
    }
}
