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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG")]
    public unsafe partial struct VideoEncoderFrameMotionSearchModeConfig
    {
        public VideoEncoderFrameMotionSearchModeConfig
        (
            VideoEncoderFrameMotionSearchMode? motionSearchMode = null,
            uint? searchDeviationLimit = null
        ) : this()
        {
            if (motionSearchMode is not null)
            {
                MotionSearchMode = motionSearchMode.Value;
            }

            if (searchDeviationLimit is not null)
            {
                SearchDeviationLimit = searchDeviationLimit.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE")]
        [NativeName("Name", "MotionSearchMode")]
        public VideoEncoderFrameMotionSearchMode MotionSearchMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SearchDeviationLimit")]
        public uint SearchDeviationLimit;
    }
}
