// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADER_MISCTYPE_OFFSETS")]
    public enum ShaderMisctypeOffsets : int
    {
        [Obsolete("Deprecated in favour of \"Position\"")]
        [NativeName("Name", "D3DSMO_POSITION")]
        SmoPosition = 0x0,
        [Obsolete("Deprecated in favour of \"Face\"")]
        [NativeName("Name", "D3DSMO_FACE")]
        SmoFace = 0x1,
        [NativeName("Name", "D3DSMO_POSITION")]
        Position = 0x0,
        [NativeName("Name", "D3DSMO_FACE")]
        Face = 0x1,
    }
}
