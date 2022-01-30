// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DSTATEBLOCKTYPE")]
    public enum Stateblocktype : int
    {
        [NativeName("Name", "D3DSBT_ALL")]
        SbtAll = 0x1,
        [NativeName("Name", "D3DSBT_PIXELSTATE")]
        SbtPixelstate = 0x2,
        [NativeName("Name", "D3DSBT_VERTEXSTATE")]
        SbtVertexstate = 0x3,
        [NativeName("Name", "D3DSBT_FORCE_DWORD")]
        SbtForceDword = 0x7FFFFFFF,
    }
}
