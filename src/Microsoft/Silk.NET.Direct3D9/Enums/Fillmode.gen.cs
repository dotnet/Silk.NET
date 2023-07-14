// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DFILLMODE")]
    public enum Fillmode : int
    {
        [Obsolete("Deprecated in favour of \"Point\"")]
        [NativeName("Name", "D3DFILL_POINT")]
        FillPoint = 0x1,
        [Obsolete("Deprecated in favour of \"Wireframe\"")]
        [NativeName("Name", "D3DFILL_WIREFRAME")]
        FillWireframe = 0x2,
        [Obsolete("Deprecated in favour of \"Solid\"")]
        [NativeName("Name", "D3DFILL_SOLID")]
        FillSolid = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DFILL_FORCE_DWORD")]
        FillForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DFILL_POINT")]
        Point = 0x1,
        [NativeName("Name", "D3DFILL_WIREFRAME")]
        Wireframe = 0x2,
        [NativeName("Name", "D3DFILL_SOLID")]
        Solid = 0x3,
        [NativeName("Name", "D3DFILL_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
