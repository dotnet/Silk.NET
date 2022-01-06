// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DVS_RASTOUT_OFFSETS")]
    public enum VSRastoutOffsets : int
    {
        [NativeName("Name", "D3DSRO_POSITION")]
        SroPosition = 0x0,
        [NativeName("Name", "D3DSRO_FOG")]
        SroFog = 0x1,
        [NativeName("Name", "D3DSRO_POINT_SIZE")]
        SroPointSize = 0x2,
        [NativeName("Name", "D3DSRO_FORCE_DWORD")]
        SroForceDword = 0x7FFFFFFF,
    }
}
