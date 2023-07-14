// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVS_RASTOUT_OFFSETS")]
    public enum VSRastoutOffsets : int
    {
        [Obsolete("Deprecated in favour of \"Position\"")]
        [NativeName("Name", "D3DSRO_POSITION")]
        SroPosition = 0x0,
        [Obsolete("Deprecated in favour of \"Fog\"")]
        [NativeName("Name", "D3DSRO_FOG")]
        SroFog = 0x1,
        [Obsolete("Deprecated in favour of \"PointSize\"")]
        [NativeName("Name", "D3DSRO_POINT_SIZE")]
        SroPointSize = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSRO_FORCE_DWORD")]
        SroForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSRO_POSITION")]
        Position = 0x0,
        [NativeName("Name", "D3DSRO_FOG")]
        Fog = 0x1,
        [NativeName("Name", "D3DSRO_POINT_SIZE")]
        PointSize = 0x2,
        [NativeName("Name", "D3DSRO_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
