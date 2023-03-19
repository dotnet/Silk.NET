// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP")]
    public enum DirectionalblurProp : int
    {
        [Obsolete("Deprecated in favour of \"StandardDeviation\"")]
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_STANDARD_DEVIATION")]
        DirectionalblurPropStandardDeviation = 0x0,
        [Obsolete("Deprecated in favour of \"Angle\"")]
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_ANGLE")]
        DirectionalblurPropAngle = 0x1,
        [Obsolete("Deprecated in favour of \"Optimization\"")]
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_OPTIMIZATION")]
        DirectionalblurPropOptimization = 0x2,
        [Obsolete("Deprecated in favour of \"BorderMode\"")]
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_BORDER_MODE")]
        DirectionalblurPropBorderMode = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_FORCE_DWORD")]
        DirectionalblurPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_STANDARD_DEVIATION")]
        StandardDeviation = 0x0,
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_ANGLE")]
        Angle = 0x1,
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_OPTIMIZATION")]
        Optimization = 0x2,
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_BORDER_MODE")]
        BorderMode = 0x3,
        [NativeName("Name", "D2D1_DIRECTIONALBLUR_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
