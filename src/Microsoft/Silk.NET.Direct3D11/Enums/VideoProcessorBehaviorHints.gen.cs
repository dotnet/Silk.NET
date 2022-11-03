// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS")]
    public enum VideoProcessorBehaviorHints : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MultiplaneOverlayRotation\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_ROTATION")]
        VideoProcessorBehaviorHintMultiplaneOverlayRotation = 0x1,
        [Obsolete("Deprecated in favour of \"MultiplaneOverlayResize\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_RESIZE")]
        VideoProcessorBehaviorHintMultiplaneOverlayResize = 0x2,
        [Obsolete("Deprecated in favour of \"MultiplaneOverlayColorSpaceConversion\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_COLOR_SPACE_CONVERSION")]
        VideoProcessorBehaviorHintMultiplaneOverlayColorSpaceConversion = 0x4,
        [Obsolete("Deprecated in favour of \"TripleBufferOutput\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_TRIPLE_BUFFER_OUTPUT")]
        VideoProcessorBehaviorHintTripleBufferOutput = 0x8,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_ROTATION")]
        MultiplaneOverlayRotation = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_RESIZE")]
        MultiplaneOverlayResize = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_COLOR_SPACE_CONVERSION")]
        MultiplaneOverlayColorSpaceConversion = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_TRIPLE_BUFFER_OUTPUT")]
        TripleBufferOutput = 0x8,
    }
}
