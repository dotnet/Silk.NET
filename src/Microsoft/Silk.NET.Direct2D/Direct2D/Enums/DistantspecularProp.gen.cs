// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP")]
    public enum DistantspecularProp : int
    {
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_AZIMUTH")]
        Azimuth = 0x0,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_ELEVATION")]
        Elevation = 0x1,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SPECULAR_EXPONENT")]
        SpecularExponent = 0x2,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SPECULAR_CONSTANT")]
        SpecularConstant = 0x3,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SURFACE_SCALE")]
        SurfaceScale = 0x4,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_COLOR")]
        Color = 0x5,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_KERNEL_UNIT_LENGTH")]
        KernelUnitLength = 0x6,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SCALE_MODE")]
        ScaleMode = 0x7,
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
