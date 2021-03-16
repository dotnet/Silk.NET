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
    [NativeName("Name", "XrOverlaySessionCreateFlagsEXTX")]
    public enum OverlaySessionCreateFlagsEXTX : int
    {
        [NativeName("Name", "XR_OVERLAY_SESSION_CREATE_RELAXED_DISPLAY_TIME_BIT_EXTX")]
        OverlaySessionCreateRelaxedDisplayTimeBitExtx = 1,
    }
}
