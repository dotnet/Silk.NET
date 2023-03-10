// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_POINTDIFFUSE_PROP")]
    public enum PointdiffuseProp : int
    {
        [Obsolete("Deprecated in favour of \"LightPosition\"")]
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_LIGHT_POSITION")]
        PointdiffusePropLightPosition = 0x0,
        [Obsolete("Deprecated in favour of \"DiffuseConstant\"")]
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_DIFFUSE_CONSTANT")]
        PointdiffusePropDiffuseConstant = 0x1,
        [Obsolete("Deprecated in favour of \"SurfaceScale\"")]
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_SURFACE_SCALE")]
        PointdiffusePropSurfaceScale = 0x2,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_COLOR")]
        PointdiffusePropColor = 0x3,
        [Obsolete("Deprecated in favour of \"KernelUnitLength\"")]
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_KERNEL_UNIT_LENGTH")]
        PointdiffusePropKernelUnitLength = 0x4,
        [Obsolete("Deprecated in favour of \"ScaleMode\"")]
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_SCALE_MODE")]
        PointdiffusePropScaleMode = 0x5,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_FORCE_DWORD")]
        PointdiffusePropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_LIGHT_POSITION")]
        LightPosition = 0x0,
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_DIFFUSE_CONSTANT")]
        DiffuseConstant = 0x1,
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_SURFACE_SCALE")]
        SurfaceScale = 0x2,
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_COLOR")]
        Color = 0x3,
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_KERNEL_UNIT_LENGTH")]
        KernelUnitLength = 0x4,
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_SCALE_MODE")]
        ScaleMode = 0x5,
        [NativeName("Name", "D2D1_POINTDIFFUSE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
