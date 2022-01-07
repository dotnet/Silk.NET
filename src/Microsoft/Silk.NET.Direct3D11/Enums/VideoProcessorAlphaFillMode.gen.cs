// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE")]
    public enum VideoProcessorAlphaFillMode : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE")]
        VideoProcessorAlphaFillModeOpaque = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND")]
        VideoProcessorAlphaFillModeBackground = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION")]
        VideoProcessorAlphaFillModeDestination = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM")]
        VideoProcessorAlphaFillModeSourceStream = 0x3,
    }
}
