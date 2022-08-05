// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SHADOW_PROP")]
    public enum ShadowProp : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"BlurStandardDeviation\"")]
        [NativeName("Name", "D2D1_SHADOW_PROP_BLUR_STANDARD_DEVIATION")]
        ShadowPropBlurStandardDeviation = 0x0,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_SHADOW_PROP_COLOR")]
        ShadowPropColor = 0x1,
        [Obsolete("Deprecated in favour of \"Optimization\"")]
        [NativeName("Name", "D2D1_SHADOW_PROP_OPTIMIZATION")]
        ShadowPropOptimization = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SHADOW_PROP_FORCE_DWORD")]
        ShadowPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SHADOW_PROP_BLUR_STANDARD_DEVIATION")]
        BlurStandardDeviation = 0x0,
        [NativeName("Name", "D2D1_SHADOW_PROP_COLOR")]
        Color = 0x1,
        [NativeName("Name", "D2D1_SHADOW_PROP_OPTIMIZATION")]
        Optimization = 0x2,
        [NativeName("Name", "D2D1_SHADOW_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
