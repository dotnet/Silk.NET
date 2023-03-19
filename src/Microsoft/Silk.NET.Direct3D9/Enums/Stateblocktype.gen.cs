// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSTATEBLOCKTYPE")]
    public enum Stateblocktype : int
    {
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "D3DSBT_ALL")]
        SbtAll = 0x1,
        [Obsolete("Deprecated in favour of \"Pixelstate\"")]
        [NativeName("Name", "D3DSBT_PIXELSTATE")]
        SbtPixelstate = 0x2,
        [Obsolete("Deprecated in favour of \"Vertexstate\"")]
        [NativeName("Name", "D3DSBT_VERTEXSTATE")]
        SbtVertexstate = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSBT_FORCE_DWORD")]
        SbtForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSBT_ALL")]
        All = 0x1,
        [NativeName("Name", "D3DSBT_PIXELSTATE")]
        Pixelstate = 0x2,
        [NativeName("Name", "D3DSBT_VERTEXSTATE")]
        Vertexstate = 0x3,
        [NativeName("Name", "D3DSBT_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
