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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_DESC")]
    public unsafe partial struct VideoEncoderDesc
    {
        public VideoEncoderDesc
        (
            uint? nodeMask = null,
            VideoEncoderFlags? flags = null,
            VideoEncoderCodec? encodeCodec = null,
            VideoEncoderProfileDesc? encodeProfile = null,
            Silk.NET.DXGI.Format? inputFormat = null,
            VideoEncoderCodecConfiguration? codecConfiguration = null,
            VideoEncoderMotionEstimationPrecisionMode? maxMotionEstimationPrecision = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (encodeCodec is not null)
            {
                EncodeCodec = encodeCodec.Value;
            }

            if (encodeProfile is not null)
            {
                EncodeProfile = encodeProfile.Value;
            }

            if (inputFormat is not null)
            {
                InputFormat = inputFormat.Value;
            }

            if (codecConfiguration is not null)
            {
                CodecConfiguration = codecConfiguration.Value;
            }

            if (maxMotionEstimationPrecision is not null)
            {
                MaxMotionEstimationPrecision = maxMotionEstimationPrecision.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Name", "EncodeCodec")]
        public VideoEncoderCodec EncodeCodec;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Name", "EncodeProfile")]
        public VideoEncoderProfileDesc EncodeProfile;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "InputFormat")]
        public Silk.NET.DXGI.Format InputFormat;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION")]
        [NativeName("Name", "CodecConfiguration")]
        public VideoEncoderCodecConfiguration CodecConfiguration;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE")]
        [NativeName("Name", "MaxMotionEstimationPrecision")]
        public VideoEncoderMotionEstimationPrecisionMode MaxMotionEstimationPrecision;
    }
}
