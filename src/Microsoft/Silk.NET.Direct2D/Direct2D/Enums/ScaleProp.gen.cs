// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SCALE_PROP")]
    public enum ScaleProp : int
    {
        [NativeName("Name", "D2D1_SCALE_PROP_SCALE")]
        Scale = 0x0,
        [NativeName("Name", "D2D1_SCALE_PROP_CENTER_POINT")]
        CenterPoint = 0x1,
        [NativeName("Name", "D2D1_SCALE_PROP_INTERPOLATION_MODE")]
        InterpolationMode = 0x2,
        [NativeName("Name", "D2D1_SCALE_PROP_BORDER_MODE")]
        BorderMode = 0x3,
        [NativeName("Name", "D2D1_SCALE_PROP_SHARPNESS")]
        Sharpness = 0x4,
        [NativeName("Name", "D2D1_SCALE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
