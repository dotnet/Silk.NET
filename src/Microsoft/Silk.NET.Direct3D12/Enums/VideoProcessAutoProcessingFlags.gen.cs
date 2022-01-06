// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS")]
    public enum VideoProcessAutoProcessingFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE")]
        VideoProcessAutoProcessingFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE")]
        VideoProcessAutoProcessingFlagDenoise = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING")]
        VideoProcessAutoProcessingFlagDeringing = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT")]
        VideoProcessAutoProcessingFlagEdgeEnhancement = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION")]
        VideoProcessAutoProcessingFlagColorCorrection = 0x8,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING")]
        VideoProcessAutoProcessingFlagFleshToneMapping = 0x10,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION")]
        VideoProcessAutoProcessingFlagImageStabilization = 0x20,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION")]
        VideoProcessAutoProcessingFlagSuperResolution = 0x40,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING")]
        VideoProcessAutoProcessingFlagAnamorphicScaling = 0x80,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM")]
        VideoProcessAutoProcessingFlagCustom = unchecked((int) 0xFFFFFFFF80000000),
    }
}
