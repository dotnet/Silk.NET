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
        [Obsolete("Deprecated in favour of \"Azimuth\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_AZIMUTH")]
        DistantspecularPropAzimuth = 0x0,
        [Obsolete("Deprecated in favour of \"Elevation\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_ELEVATION")]
        DistantspecularPropElevation = 0x1,
        [Obsolete("Deprecated in favour of \"SpecularExponent\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SPECULAR_EXPONENT")]
        DistantspecularPropSpecularExponent = 0x2,
        [Obsolete("Deprecated in favour of \"SpecularConstant\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SPECULAR_CONSTANT")]
        DistantspecularPropSpecularConstant = 0x3,
        [Obsolete("Deprecated in favour of \"SurfaceScale\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SURFACE_SCALE")]
        DistantspecularPropSurfaceScale = 0x4,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_COLOR")]
        DistantspecularPropColor = 0x5,
        [Obsolete("Deprecated in favour of \"KernelUnitLength\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_KERNEL_UNIT_LENGTH")]
        DistantspecularPropKernelUnitLength = 0x6,
        [Obsolete("Deprecated in favour of \"ScaleMode\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_SCALE_MODE")]
        DistantspecularPropScaleMode = 0x7,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_DISTANTSPECULAR_PROP_FORCE_DWORD")]
        DistantspecularPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
