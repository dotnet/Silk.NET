// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE")]
    public enum VideoProcessorAlphaFillMode : int
    {
        [Obsolete("Deprecated in favour of \"Opaque\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE")]
        VideoProcessorAlphaFillModeOpaque = 0x0,
        [Obsolete("Deprecated in favour of \"Background\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND")]
        VideoProcessorAlphaFillModeBackground = 0x1,
        [Obsolete("Deprecated in favour of \"Destination\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION")]
        VideoProcessorAlphaFillModeDestination = 0x2,
        [Obsolete("Deprecated in favour of \"SourceStream\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM")]
        VideoProcessorAlphaFillModeSourceStream = 0x3,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE")]
        Opaque = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND")]
        Background = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION")]
        Destination = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM")]
        SourceStream = 0x3,
    }
}
