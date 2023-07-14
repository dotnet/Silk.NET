// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_COLORMANAGEMENT_RENDERING_INTENT")]
    public enum ColormanagementRenderingIntent : int
    {
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
