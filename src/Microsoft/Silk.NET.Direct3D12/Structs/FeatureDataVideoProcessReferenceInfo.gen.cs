// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            uint nodeIndex = default,
            VideoProcessDeinterlaceFlags deinterlaceMode = default,
            VideoProcessFilterFlags filters = default,
            VideoProcessFeatureFlags featureSupport = default,
            Silk.NET.DXGI.Rational inputFrameRate = default,
            Silk.NET.DXGI.Rational outputFrameRate = default,
            int enableAutoProcessing = default,
            uint pastFrames = default,
            uint futureFrames = default
        )
        {
            NodeIndex = nodeIndex;
            DeinterlaceMode = deinterlaceMode;
            Filters = filters;
            FeatureSupport = featureSupport;
            InputFrameRate = inputFrameRate;
            OutputFrameRate = outputFrameRate;
            EnableAutoProcessing = enableAutoProcessing;
            PastFrames = pastFrames;
            FutureFrames = futureFrames;
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
        public int EnableAutoProcessing;

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
