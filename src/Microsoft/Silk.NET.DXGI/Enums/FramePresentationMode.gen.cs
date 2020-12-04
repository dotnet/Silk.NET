// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_FRAME_PRESENTATION_MODE")]
    public enum FramePresentationMode
    {
        [NativeName("Name", "DXGI_FRAME_PRESENTATION_MODE_COMPOSED")]
        FramePresentationModeComposed = 0x0,
        [NativeName("Name", "DXGI_FRAME_PRESENTATION_MODE_OVERLAY")]
        FramePresentationModeOverlay = 0x1,
        [NativeName("Name", "DXGI_FRAME_PRESENTATION_MODE_NONE")]
        FramePresentationModeNone = 0x2,
        [NativeName("Name", "DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE")]
        FramePresentationModeCompositionFailure = 0x3,
    }
}
