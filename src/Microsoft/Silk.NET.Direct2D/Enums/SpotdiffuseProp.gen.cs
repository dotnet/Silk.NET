// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP")]
    public enum SpotdiffuseProp : int
    {
        [Obsolete("Deprecated in favour of \"LightPosition\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_LIGHT_POSITION")]
        SpotdiffusePropLightPosition = 0x0,
        [Obsolete("Deprecated in favour of \"PointsAT\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_POINTS_AT")]
        SpotdiffusePropPointsAT = 0x1,
        [Obsolete("Deprecated in favour of \"Focus\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_FOCUS")]
        SpotdiffusePropFocus = 0x2,
        [Obsolete("Deprecated in favour of \"LimitingConeAngle\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_LIMITING_CONE_ANGLE")]
        SpotdiffusePropLimitingConeAngle = 0x3,
        [Obsolete("Deprecated in favour of \"DiffuseConstant\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_DIFFUSE_CONSTANT")]
        SpotdiffusePropDiffuseConstant = 0x4,
        [Obsolete("Deprecated in favour of \"SurfaceScale\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_SURFACE_SCALE")]
        SpotdiffusePropSurfaceScale = 0x5,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_COLOR")]
        SpotdiffusePropColor = 0x6,
        [Obsolete("Deprecated in favour of \"KernelUnitLength\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_KERNEL_UNIT_LENGTH")]
        SpotdiffusePropKernelUnitLength = 0x7,
        [Obsolete("Deprecated in favour of \"ScaleMode\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_SCALE_MODE")]
        SpotdiffusePropScaleMode = 0x8,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_FORCE_DWORD")]
        SpotdiffusePropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_LIGHT_POSITION")]
        LightPosition = 0x0,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_POINTS_AT")]
        PointsAT = 0x1,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_FOCUS")]
        Focus = 0x2,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_LIMITING_CONE_ANGLE")]
        LimitingConeAngle = 0x3,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_DIFFUSE_CONSTANT")]
        DiffuseConstant = 0x4,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_SURFACE_SCALE")]
        SurfaceScale = 0x5,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_COLOR")]
        Color = 0x6,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_KERNEL_UNIT_LENGTH")]
        KernelUnitLength = 0x7,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_SCALE_MODE")]
        ScaleMode = 0x8,
        [NativeName("Name", "D2D1_SPOTDIFFUSE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
