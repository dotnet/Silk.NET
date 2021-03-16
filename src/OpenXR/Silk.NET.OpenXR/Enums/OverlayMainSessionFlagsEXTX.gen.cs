// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrOverlayMainSessionFlagsEXTX")]
    public enum OverlayMainSessionFlagsEXTX : int
    {
        [NativeName("Name", "XR_OVERLAY_MAIN_SESSION_ENABLED_COMPOSITION_LAYER_INFO_DEPTH_BIT_EXTX")]
        OverlayMainSessionEnabledCompositionLayerInfoDepthBitExtx = 1,
    }
}
