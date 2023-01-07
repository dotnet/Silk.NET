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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO")]
    public unsafe partial struct FeatureDataVideoProcessReferenceInfo
    {
        public FeatureDataVideoProcessReferenceInfo
        (
            uint? nodeIndex = null,
            VideoProcessDeinterlaceFlags? deinterlaceMode = null,
            VideoProcessFilterFlags? filters = null,
            VideoProcessFeatureFlags? featureSupport = null,
            Silk.NET.DXGI.Rational? inputFrameRate = null,
            Silk.NET.DXGI.Rational? outputFrameRate = null,
            Silk.NET.Core.Bool32? enableAutoProcessing = null,
            uint? pastFrames = null,
            uint? futureFrames = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (deinterlaceMode is not null)
            {
                DeinterlaceMode = deinterlaceMode.Value;
            }

            if (filters is not null)
            {
                Filters = filters.Value;
            }

            if (featureSupport is not null)
            {
                FeatureSupport = featureSupport.Value;
            }

            if (inputFrameRate is not null)
            {
                InputFrameRate = inputFrameRate.Value;
            }

            if (outputFrameRate is not null)
            {
                OutputFrameRate = outputFrameRate.Value;
            }

            if (enableAutoProcessing is not null)
            {
                EnableAutoProcessing = enableAutoProcessing.Value;
            }

            if (pastFrames is not null)
            {
                PastFrames = pastFrames.Value;
            }

            if (futureFrames is not null)
            {
                FutureFrames = futureFrames.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
        [NativeName("Name", "DeinterlaceMode")]
        public VideoProcessDeinterlaceFlags DeinterlaceMode;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
        [NativeName("Name", "Filters")]
        public VideoProcessFilterFlags Filters;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_FEATURE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FEATURE_FLAGS")]
        [NativeName("Name", "FeatureSupport")]
        public VideoProcessFeatureFlags FeatureSupport;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "InputFrameRate")]
        public Silk.NET.DXGI.Rational InputFrameRate;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "OutputFrameRate")]
        public Silk.NET.DXGI.Rational OutputFrameRate;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableAutoProcessing")]
        public Silk.NET.Core.Bool32 EnableAutoProcessing;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PastFrames")]
        public uint PastFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FutureFrames")]
        public uint FutureFrames;
    }
}
