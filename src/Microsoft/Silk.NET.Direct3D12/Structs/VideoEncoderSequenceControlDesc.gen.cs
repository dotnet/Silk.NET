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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC")]
    public unsafe partial struct VideoEncoderSequenceControlDesc
    {
        public VideoEncoderSequenceControlDesc
        (
            VideoEncoderSequenceControlFlags? flags = null,
            VideoEncoderIntraRefresh? intraRefreshConfig = null,
            VideoEncoderRateControl? rateControl = null,
            VideoEncoderPictureResolutionDesc? pictureTargetResolution = null,
            VideoEncoderFrameSubregionLayoutMode? selectedLayoutMode = null,
            VideoEncoderPictureControlSubregionsLayoutData? frameSubregionsLayoutData = null,
            VideoEncoderSequenceGopStructure? codecGopSequence = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (intraRefreshConfig is not null)
            {
                IntraRefreshConfig = intraRefreshConfig.Value;
            }

            if (rateControl is not null)
            {
                RateControl = rateControl.Value;
            }

            if (pictureTargetResolution is not null)
            {
                PictureTargetResolution = pictureTargetResolution.Value;
            }

            if (selectedLayoutMode is not null)
            {
                SelectedLayoutMode = selectedLayoutMode.Value;
            }

            if (frameSubregionsLayoutData is not null)
            {
                FrameSubregionsLayoutData = frameSubregionsLayoutData.Value;
            }

            if (codecGopSequence is not null)
            {
                CodecGopSequence = codecGopSequence.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderSequenceControlFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_INTRA_REFRESH")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH")]
        [NativeName("Name", "IntraRefreshConfig")]
        public VideoEncoderIntraRefresh IntraRefreshConfig;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_RATE_CONTROL")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL")]
        [NativeName("Name", "RateControl")]
        public VideoEncoderRateControl RateControl;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC")]
        [NativeName("Name", "PictureTargetResolution")]
        public VideoEncoderPictureResolutionDesc PictureTargetResolution;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE")]
        [NativeName("Name", "SelectedLayoutMode")]
        public VideoEncoderFrameSubregionLayoutMode SelectedLayoutMode;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA")]
        [NativeName("Name", "FrameSubregionsLayoutData")]
        public VideoEncoderPictureControlSubregionsLayoutData FrameSubregionsLayoutData;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE")]
        [NativeName("Name", "CodecGopSequence")]
        public VideoEncoderSequenceGopStructure CodecGopSequence;
    }
}
