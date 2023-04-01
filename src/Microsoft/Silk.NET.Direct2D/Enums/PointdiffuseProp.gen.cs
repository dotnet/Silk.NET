// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_POINTDIFFUSE_PROP")]
    public enum PointdiffuseProp : int
    {
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
