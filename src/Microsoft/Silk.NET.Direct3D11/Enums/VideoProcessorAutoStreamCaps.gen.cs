// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS")]
    public enum VideoProcessorAutoStreamCaps : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DENOISE")]
        VideoProcessorAutoStreamCapsDenoise = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_DERINGING")]
        VideoProcessorAutoStreamCapsDeringing = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_EDGE_ENHANCEMENT")]
        VideoProcessorAutoStreamCapsEdgeEnhancement = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_COLOR_CORRECTION")]
        VideoProcessorAutoStreamCapsColorCorrection = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_FLESH_TONE_MAPPING")]
        VideoProcessorAutoStreamCapsFleshToneMapping = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_IMAGE_STABILIZATION")]
        VideoProcessorAutoStreamCapsImageStabilization = 0x20,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_SUPER_RESOLUTION")]
        VideoProcessorAutoStreamCapsSuperResolution = 0x40,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_AUTO_STREAM_CAPS_ANAMORPHIC_SCALING")]
        VideoProcessorAutoStreamCapsAnamorphicScaling = 0x80,
    }
}
