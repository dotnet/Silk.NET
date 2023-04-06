// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_PROP")]
    public enum HighlightsandshadowsProp : int
    {
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_PROP_HIGHLIGHTS")]
        Highlights = 0x0,
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_PROP_SHADOWS")]
        Shadows = 0x1,
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_PROP_CLARITY")]
        Clarity = 0x2,
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_PROP_INPUT_GAMMA")]
        InputGamma = 0x3,
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_PROP_MASK_BLUR_RADIUS")]
        MaskBlurRadius = 0x4,
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
