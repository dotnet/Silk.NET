// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT")]
    public enum ColormanagementRenderingIntent : int
    {
        [Obsolete("Deprecated in favour of \"Perceptual\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL")]
        ColormanagementRenderingIntentPerceptual = 0x0,
        [Obsolete("Deprecated in favour of \"RelativeColorimetric\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_RELATIVE_COLORIMETRIC")]
        ColormanagementRenderingIntentRelativeColorimetric = 0x1,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_SATURATION")]
        ColormanagementRenderingIntentSaturation = 0x2,
        [Obsolete("Deprecated in favour of \"AbsoluteColorimetric\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_ABSOLUTE_COLORIMETRIC")]
        ColormanagementRenderingIntentAbsoluteColorimetric = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_FORCE_DWORD")]
        ColormanagementRenderingIntentForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_PERCEPTUAL")]
        Perceptual = 0x0,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_RELATIVE_COLORIMETRIC")]
        RelativeColorimetric = 0x1,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_SATURATION")]
        Saturation = 0x2,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_ABSOLUTE_COLORIMETRIC")]
        AbsoluteColorimetric = 0x3,
        [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
