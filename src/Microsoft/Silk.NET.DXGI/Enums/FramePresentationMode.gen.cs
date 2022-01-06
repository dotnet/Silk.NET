// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_FRAME_PRESENTATION_MODE")]
    public enum FramePresentationMode : int
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
