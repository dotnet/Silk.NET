// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE")]
    public enum VideoProcessAlphaFillMode : int
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE")]
        VideoProcessAlphaFillModeOpaque = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND")]
        VideoProcessAlphaFillModeBackground = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION")]
        VideoProcessAlphaFillModeDestination = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM")]
        VideoProcessAlphaFillModeSourceStream = 0x3,
    }
}
