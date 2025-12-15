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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO")]
    public unsafe partial struct VideoEncoderMoveregionInfo
    {
        public VideoEncoderMoveregionInfo
        (
            uint? numMoveRegions = null,
            VideoEncoderMoveRect* pMoveRegions = null,
            VideoEncoderFrameMotionSearchModeConfig? motionSearchModeConfiguration = null,
            uint? sourceDPBFrameReference = null,
            VideoEncoderFrameInputMotionUnitPrecision? motionUnitPrecision = null,
            VideoEncoderMoveregionInfoFlags? flags = null
        ) : this()
        {
            if (numMoveRegions is not null)
            {
                NumMoveRegions = numMoveRegions.Value;
            }

            if (pMoveRegions is not null)
            {
                PMoveRegions = pMoveRegions;
            }

            if (motionSearchModeConfiguration is not null)
            {
                MotionSearchModeConfiguration = motionSearchModeConfiguration.Value;
            }

            if (sourceDPBFrameReference is not null)
            {
                SourceDPBFrameReference = sourceDPBFrameReference.Value;
            }

            if (motionUnitPrecision is not null)
            {
                MotionUnitPrecision = motionUnitPrecision.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumMoveRegions")]
        public uint NumMoveRegions;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_MOVE_RECT *")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_MOVE_RECT *")]
        [NativeName("Name", "pMoveRegions")]
        public VideoEncoderMoveRect* PMoveRegions;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG")]
        [NativeName("Name", "MotionSearchModeConfiguration")]
        public VideoEncoderFrameMotionSearchModeConfig MotionSearchModeConfiguration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SourceDPBFrameReference")]
        public uint SourceDPBFrameReference;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION")]
        [NativeName("Name", "MotionUnitPrecision")]
        public VideoEncoderFrameInputMotionUnitPrecision MotionUnitPrecision;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderMoveregionInfoFlags Flags;
    }
}
