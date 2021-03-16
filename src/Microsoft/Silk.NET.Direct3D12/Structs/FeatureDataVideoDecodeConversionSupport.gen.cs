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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT")]
    public unsafe partial struct FeatureDataVideoDecodeConversionSupport
    {
        public FeatureDataVideoDecodeConversionSupport
        (
            uint? nodeIndex = null,
            VideoDecodeConfiguration? configuration = null,
            VideoSample? decodeSample = null,
            VideoFormat? outputFormat = null,
            Silk.NET.DXGI.Rational? frameRate = null,
            uint? bitRate = null,
            VideoDecodeConversionSupportFlags? supportFlags = null,
            VideoScaleSupport? scaleSupport = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (configuration is not null)
            {
                Configuration = configuration.Value;
            }

            if (decodeSample is not null)
            {
                DecodeSample = decodeSample.Value;
            }

            if (outputFormat is not null)
            {
                OutputFormat = outputFormat.Value;
            }

            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (bitRate is not null)
            {
                BitRate = bitRate.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

            if (scaleSupport is not null)
            {
                ScaleSupport = scaleSupport.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Name", "Configuration")]
        public VideoDecodeConfiguration Configuration;

        [NativeName("Type", "D3D12_VIDEO_SAMPLE")]
        [NativeName("Type.Name", "D3D12_VIDEO_SAMPLE")]
        [NativeName("Name", "DecodeSample")]
        public VideoSample DecodeSample;

        [NativeName("Type", "D3D12_VIDEO_FORMAT")]
        [NativeName("Type.Name", "D3D12_VIDEO_FORMAT")]
        [NativeName("Name", "OutputFormat")]
        public VideoFormat OutputFormat;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "FrameRate")]
        public Silk.NET.DXGI.Rational FrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BitRate")]
        public uint BitRate;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoDecodeConversionSupportFlags SupportFlags;

        [NativeName("Type", "D3D12_VIDEO_SCALE_SUPPORT")]
        [NativeName("Type.Name", "D3D12_VIDEO_SCALE_SUPPORT")]
        [NativeName("Name", "ScaleSupport")]
        public VideoScaleSupport ScaleSupport;
    }
}
