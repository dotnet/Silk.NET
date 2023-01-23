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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT")]
    public unsafe partial struct FeatureDataVideoProcessSupport
    {
        public FeatureDataVideoProcessSupport
        (
            uint? nodeIndex = null,
            VideoSample? inputSample = null,
            VideoFieldType? inputFieldType = null,
            VideoFrameStereoFormat? inputStereoFormat = null,
            Silk.NET.DXGI.Rational? inputFrameRate = null,
            VideoFormat? outputFormat = null,
            VideoFrameStereoFormat? outputStereoFormat = null,
            Silk.NET.DXGI.Rational? outputFrameRate = null,
            VideoProcessSupportFlags? supportFlags = null,
            VideoScaleSupport? scaleSupport = null,
            VideoProcessFeatureFlags? featureSupport = null,
            VideoProcessDeinterlaceFlags? deinterlaceSupport = null,
            VideoProcessAutoProcessingFlags? autoProcessingSupport = null,
            VideoProcessFilterFlags? filterSupport = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (inputSample is not null)
            {
                InputSample = inputSample.Value;
            }

            if (inputFieldType is not null)
            {
                InputFieldType = inputFieldType.Value;
            }

            if (inputStereoFormat is not null)
            {
                InputStereoFormat = inputStereoFormat.Value;
            }

            if (inputFrameRate is not null)
            {
                InputFrameRate = inputFrameRate.Value;
            }

            if (outputFormat is not null)
            {
                OutputFormat = outputFormat.Value;
            }

            if (outputStereoFormat is not null)
            {
                OutputStereoFormat = outputStereoFormat.Value;
            }

            if (outputFrameRate is not null)
            {
                OutputFrameRate = outputFrameRate.Value;
            }

            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }

            if (scaleSupport is not null)
            {
                ScaleSupport = scaleSupport.Value;
            }

            if (featureSupport is not null)
            {
                FeatureSupport = featureSupport.Value;
            }

            if (deinterlaceSupport is not null)
            {
                DeinterlaceSupport = deinterlaceSupport.Value;
            }

            if (autoProcessingSupport is not null)
            {
                AutoProcessingSupport = autoProcessingSupport.Value;
            }

            if (filterSupport is not null)
            {
                FilterSupport = filterSupport.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_SAMPLE")]
        [NativeName("Type.Name", "D3D12_VIDEO_SAMPLE")]
        [NativeName("Name", "InputSample")]
        public VideoSample InputSample;

        [NativeName("Type", "D3D12_VIDEO_FIELD_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_FIELD_TYPE")]
        [NativeName("Name", "InputFieldType")]
        public VideoFieldType InputFieldType;

        [NativeName("Type", "D3D12_VIDEO_FRAME_STEREO_FORMAT")]
        [NativeName("Type.Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT")]
        [NativeName("Name", "InputStereoFormat")]
        public VideoFrameStereoFormat InputStereoFormat;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "InputFrameRate")]
        public Silk.NET.DXGI.Rational InputFrameRate;

        [NativeName("Type", "D3D12_VIDEO_FORMAT")]
        [NativeName("Type.Name", "D3D12_VIDEO_FORMAT")]
        [NativeName("Name", "OutputFormat")]
        public VideoFormat OutputFormat;

        [NativeName("Type", "D3D12_VIDEO_FRAME_STEREO_FORMAT")]
        [NativeName("Type.Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT")]
        [NativeName("Name", "OutputStereoFormat")]
        public VideoFrameStereoFormat OutputStereoFormat;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "OutputFrameRate")]
        public Silk.NET.DXGI.Rational OutputFrameRate;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoProcessSupportFlags SupportFlags;

        [NativeName("Type", "D3D12_VIDEO_SCALE_SUPPORT")]
        [NativeName("Type.Name", "D3D12_VIDEO_SCALE_SUPPORT")]
        [NativeName("Name", "ScaleSupport")]
        public VideoScaleSupport ScaleSupport;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_FEATURE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAGS")]
        [NativeName("Name", "FeatureSupport")]
        public VideoProcessFeatureFlags FeatureSupport;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
        [NativeName("Name", "DeinterlaceSupport")]
        public VideoProcessDeinterlaceFlags DeinterlaceSupport;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS")]
        [NativeName("Name", "AutoProcessingSupport")]
        public VideoProcessAutoProcessingFlags AutoProcessingSupport;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
        [NativeName("Name", "FilterSupport")]
        public VideoProcessFilterFlags FilterSupport;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE[32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE[32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public FilterRangeSupportBuffer FilterRangeSupport;

        public struct FilterRangeSupportBuffer
        {
            public VideoProcessFilterRange Element0;
            public VideoProcessFilterRange Element1;
            public VideoProcessFilterRange Element2;
            public VideoProcessFilterRange Element3;
            public VideoProcessFilterRange Element4;
            public VideoProcessFilterRange Element5;
            public VideoProcessFilterRange Element6;
            public VideoProcessFilterRange Element7;
            public VideoProcessFilterRange Element8;
            public VideoProcessFilterRange Element9;
            public VideoProcessFilterRange Element10;
            public VideoProcessFilterRange Element11;
            public VideoProcessFilterRange Element12;
            public VideoProcessFilterRange Element13;
            public VideoProcessFilterRange Element14;
            public VideoProcessFilterRange Element15;
            public VideoProcessFilterRange Element16;
            public VideoProcessFilterRange Element17;
            public VideoProcessFilterRange Element18;
            public VideoProcessFilterRange Element19;
            public VideoProcessFilterRange Element20;
            public VideoProcessFilterRange Element21;
            public VideoProcessFilterRange Element22;
            public VideoProcessFilterRange Element23;
            public VideoProcessFilterRange Element24;
            public VideoProcessFilterRange Element25;
            public VideoProcessFilterRange Element26;
            public VideoProcessFilterRange Element27;
            public VideoProcessFilterRange Element28;
            public VideoProcessFilterRange Element29;
            public VideoProcessFilterRange Element30;
            public VideoProcessFilterRange Element31;
            public ref VideoProcessFilterRange this[int index]
            {
                get
                {
                    if (index > 31 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoProcessFilterRange* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoProcessFilterRange> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 32);
#endif
        }

    }
}
