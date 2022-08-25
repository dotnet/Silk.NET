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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE")]
        VideoProcessAutoProcessingFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Denoise\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE")]
        VideoProcessAutoProcessingFlagDenoise = 0x1,
        [Obsolete("Deprecated in favour of \"Deringing\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING")]
        VideoProcessAutoProcessingFlagDeringing = 0x2,
        [Obsolete("Deprecated in favour of \"EdgeEnhancement\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT")]
        VideoProcessAutoProcessingFlagEdgeEnhancement = 0x4,
        [Obsolete("Deprecated in favour of \"ColorCorrection\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION")]
        VideoProcessAutoProcessingFlagColorCorrection = 0x8,
        [Obsolete("Deprecated in favour of \"FleshToneMapping\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING")]
        VideoProcessAutoProcessingFlagFleshToneMapping = 0x10,
        [Obsolete("Deprecated in favour of \"ImageStabilization\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION")]
        VideoProcessAutoProcessingFlagImageStabilization = 0x20,
        [Obsolete("Deprecated in favour of \"SuperResolution\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION")]
        VideoProcessAutoProcessingFlagSuperResolution = 0x40,
        [Obsolete("Deprecated in favour of \"AnamorphicScaling\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING")]
        VideoProcessAutoProcessingFlagAnamorphicScaling = 0x80,
        [Obsolete("Deprecated in favour of \"Custom\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM")]
        VideoProcessAutoProcessingFlagCustom = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE")]
        Denoise = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING")]
        Deringing = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT")]
        EdgeEnhancement = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION")]
        ColorCorrection = 0x8,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING")]
        FleshToneMapping = 0x10,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION")]
        ImageStabilization = 0x20,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION")]
        SuperResolution = 0x40,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING")]
        AnamorphicScaling = 0x80,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM")]
        Custom = unchecked((int) 0xFFFFFFFF80000000),
    }
}
