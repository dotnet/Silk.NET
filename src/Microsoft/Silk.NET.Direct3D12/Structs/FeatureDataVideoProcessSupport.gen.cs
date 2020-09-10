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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT")]
    public unsafe partial struct FeatureDataVideoProcessSupport
    {
        public FeatureDataVideoProcessSupport
        (
            uint nodeIndex = default,
            VideoSample inputSample = default,
            VideoFieldType inputFieldType = default,
            VideoFrameStereoFormat inputStereoFormat = default,
            Silk.NET.DXGI.Rational inputFrameRate = default,
            VideoFormat outputFormat = default,
            VideoFrameStereoFormat outputStereoFormat = default,
            Silk.NET.DXGI.Rational outputFrameRate = default,
            VideoProcessSupportFlags supportFlags = default,
            VideoScaleSupport scaleSupport = default,
            VideoProcessFeatureFlags featureSupport = default,
            VideoProcessDeinterlaceFlags deinterlaceSupport = default,
            VideoProcessAutoProcessingFlags autoProcessingSupport = default,
            VideoProcessFilterFlags filterSupport = default
        )
        {
            NodeIndex = nodeIndex;
            InputSample = inputSample;
            InputFieldType = inputFieldType;
            InputStereoFormat = inputStereoFormat;
            InputFrameRate = inputFrameRate;
            OutputFormat = outputFormat;
            OutputStereoFormat = outputStereoFormat;
            OutputFrameRate = outputFrameRate;
            SupportFlags = supportFlags;
            ScaleSupport = scaleSupport;
            FeatureSupport = featureSupport;
            DeinterlaceSupport = deinterlaceSupport;
            AutoProcessingSupport = autoProcessingSupport;
            FilterSupport = filterSupport;
           FilterRangeSupport_0 = default;
           FilterRangeSupport_1 = default;
           FilterRangeSupport_2 = default;
           FilterRangeSupport_3 = default;
           FilterRangeSupport_4 = default;
           FilterRangeSupport_5 = default;
           FilterRangeSupport_6 = default;
           FilterRangeSupport_7 = default;
           FilterRangeSupport_8 = default;
           FilterRangeSupport_9 = default;
           FilterRangeSupport_10 = default;
           FilterRangeSupport_11 = default;
           FilterRangeSupport_12 = default;
           FilterRangeSupport_13 = default;
           FilterRangeSupport_14 = default;
           FilterRangeSupport_15 = default;
           FilterRangeSupport_16 = default;
           FilterRangeSupport_17 = default;
           FilterRangeSupport_18 = default;
           FilterRangeSupport_19 = default;
           FilterRangeSupport_20 = default;
           FilterRangeSupport_21 = default;
           FilterRangeSupport_22 = default;
           FilterRangeSupport_23 = default;
           FilterRangeSupport_24 = default;
           FilterRangeSupport_25 = default;
           FilterRangeSupport_26 = default;
           FilterRangeSupport_27 = default;
           FilterRangeSupport_28 = default;
           FilterRangeSupport_29 = default;
           FilterRangeSupport_30 = default;
           FilterRangeSupport_31 = default;
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
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_0;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_1;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_2;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_3;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_4;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_5;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_6;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_7;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_8;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_9;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_10;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_11;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_12;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_13;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_14;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_15;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_16;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_17;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_18;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_19;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_20;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_21;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_22;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_23;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_24;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_25;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_26;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_27;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_28;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_29;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_30;
        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_RANGE [32]")]
        [NativeName("Name", "FilterRangeSupport")]
        public VideoProcessFilterRange FilterRangeSupport_31;
    }
}
