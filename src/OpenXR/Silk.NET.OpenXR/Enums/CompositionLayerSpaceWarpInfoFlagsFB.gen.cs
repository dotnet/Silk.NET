// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrCompositionLayerSpaceWarpInfoFlagsFB")]
    public enum CompositionLayerSpaceWarpInfoFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FrameSkipBitFB\"")]
        [NativeName("Name", "XR_COMPOSITION_LAYER_SPACE_WARP_INFO_FRAME_SKIP_BIT_FB")]
        CompositionLayerSpaceWarpInfoFrameSkipBitFB = 1,
        [NativeName("Name", "XR_COMPOSITION_LAYER_SPACE_WARP_INFO_FRAME_SKIP_BIT_FB")]
        FrameSkipBitFB = 1,
    }
}
