// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS")]
    public enum VideoProcessorFilterCaps : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS")]
        VideoProcessorFilterCapsBrightness = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST")]
        VideoProcessorFilterCapsContrast = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE")]
        VideoProcessorFilterCapsHue = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION")]
        VideoProcessorFilterCapsSaturation = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION")]
        VideoProcessorFilterCapsNoiseReduction = 0x10,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT")]
        VideoProcessorFilterCapsEdgeEnhancement = 0x20,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING")]
        VideoProcessorFilterCapsAnamorphicScaling = 0x40,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT")]
        VideoProcessorFilterCapsStereoAdjustment = 0x80,
    }
}
