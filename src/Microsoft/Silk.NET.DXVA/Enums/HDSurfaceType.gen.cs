// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_SURFACE_TYPE")]
    public enum HDSurfaceType : int
    {
        [Obsolete("Deprecated in favour of \"Input\"")]
        [NativeName("Name", "DXVAHD_SURFACE_TYPE_VIDEO_INPUT")]
        HDSurfaceTypeVideoInput = 0x0,
        [Obsolete("Deprecated in favour of \"InputPrivate\"")]
        [NativeName("Name", "DXVAHD_SURFACE_TYPE_VIDEO_INPUT_PRIVATE")]
        HDSurfaceTypeVideoInputPrivate = 0x1,
        [Obsolete("Deprecated in favour of \"Output\"")]
        [NativeName("Name", "DXVAHD_SURFACE_TYPE_VIDEO_OUTPUT")]
        HDSurfaceTypeVideoOutput = 0x2,
        [NativeName("Name", "DXVAHD_SURFACE_TYPE_VIDEO_INPUT")]
        Input = 0x0,
        [NativeName("Name", "DXVAHD_SURFACE_TYPE_VIDEO_INPUT_PRIVATE")]
        InputPrivate = 0x1,
        [NativeName("Name", "DXVAHD_SURFACE_TYPE_VIDEO_OUTPUT")]
        Output = 0x2,
    }
}
