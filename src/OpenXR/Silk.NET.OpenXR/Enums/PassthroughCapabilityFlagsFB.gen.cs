// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPassthroughCapabilityFlagsFB")]
    public enum PassthroughCapabilityFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"BitFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_CAPABILITY_BIT_FB")]
        PassthroughCapabilityBitFB = 1,
        [Obsolete("Deprecated in favour of \"ColorBitFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_CAPABILITY_COLOR_BIT_FB")]
        PassthroughCapabilityColorBitFB = 2,
        [Obsolete("Deprecated in favour of \"LayerDepthBitFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_CAPABILITY_LAYER_DEPTH_BIT_FB")]
        PassthroughCapabilityLayerDepthBitFB = 4,
        [NativeName("Name", "XR_PASSTHROUGH_CAPABILITY_BIT_FB")]
        BitFB = 1,
        [NativeName("Name", "XR_PASSTHROUGH_CAPABILITY_COLOR_BIT_FB")]
        ColorBitFB = 2,
        [NativeName("Name", "XR_PASSTHROUGH_CAPABILITY_LAYER_DEPTH_BIT_FB")]
        LayerDepthBitFB = 4,
    }
}
