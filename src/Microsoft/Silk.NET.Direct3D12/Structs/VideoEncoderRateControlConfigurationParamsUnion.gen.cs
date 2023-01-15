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
    [NativeName("Name", "__AnonymousRecord_d3d12video_L6275_C5")]
    public unsafe partial struct VideoEncoderRateControlConfigurationParamsUnion
    {
        public VideoEncoderRateControlConfigurationParamsUnion
        (
            VideoEncoderRateControlCqp* pConfigurationCQP = null,
            VideoEncoderRateControlCbr* pConfigurationCBR = null,
            VideoEncoderRateControlVbr* pConfigurationVBR = null,
            VideoEncoderRateControlQvbr* pConfigurationQVBR = null
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
    }
}
