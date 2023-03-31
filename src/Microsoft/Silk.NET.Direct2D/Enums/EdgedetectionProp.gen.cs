// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_EDGEDETECTION_PROP")]
    public enum EdgedetectionProp : int
    {
        [NativeName("Name", "D2D1_EDGEDETECTION_PROP_STRENGTH")]
        Strength = 0x0,
        [NativeName("Name", "D2D1_EDGEDETECTION_PROP_BLUR_RADIUS")]
        BlurRadius = 0x1,
        [NativeName("Name", "D2D1_EDGEDETECTION_PROP_MODE")]
        Mode = 0x2,
        [NativeName("Name", "D2D1_EDGEDETECTION_PROP_OVERLAY_EDGES")]
        OverlayEdges = 0x3,
        [NativeName("Name", "D2D1_EDGEDETECTION_PROP_ALPHA_MODE")]
        AlphaMode = 0x4,
        [NativeName("Name", "D2D1_EDGEDETECTION_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
