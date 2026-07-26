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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_FRAME_ANALYSIS")]
    public unsafe partial struct FeatureDataVideoEncoderResolutionSupportFrameAnalysis
    {
        public FeatureDataVideoEncoderResolutionSupportFrameAnalysis
        (
            VideoEncoderRateControlFrameAnalysisSupportFlags? supportFlags = null
        ) : this()
        {
            if (supportFlags is not null)
            {
                SupportFlags = supportFlags.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAGS")]
        [NativeName("Name", "SupportFlags")]
        public VideoEncoderRateControlFrameAnalysisSupportFlags SupportFlags;
    }
}
