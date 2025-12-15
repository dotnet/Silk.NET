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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL")]
    public unsafe partial struct VideoEncoderRateControl
    {
        public VideoEncoderRateControl
        (
            VideoEncoderRateControlMode? mode = null,
            VideoEncoderRateControlFlags? flags = null,
            VideoEncoderRateControlConfigurationParams? configParams = null,
            Silk.NET.DXGI.Rational? targetFrameRate = null
        ) : this()
        {
            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (configParams is not null)
            {
                ConfigParams = configParams.Value;
            }

            if (targetFrameRate is not null)
            {
                TargetFrameRate = targetFrameRate.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE")]
        [NativeName("Name", "Mode")]
        public VideoEncoderRateControlMode Mode;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderRateControlFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS")]
        [NativeName("Name", "ConfigParams")]
        public VideoEncoderRateControlConfigurationParams ConfigParams;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "TargetFrameRate")]
        public Silk.NET.DXGI.Rational TargetFrameRate;
    }
}
