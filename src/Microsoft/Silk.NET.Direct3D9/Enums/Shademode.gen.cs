// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DSHADEMODE")]
    public enum Shademode : int
    {
        [Obsolete("Deprecated in favour of \"Flat\"")]
        [NativeName("Name", "D3DSHADE_FLAT")]
        ShadeFlat = 0x1,
        [Obsolete("Deprecated in favour of \"Gouraud\"")]
        [NativeName("Name", "D3DSHADE_GOURAUD")]
        ShadeGouraud = 0x2,
        [Obsolete("Deprecated in favour of \"Phong\"")]
        [NativeName("Name", "D3DSHADE_PHONG")]
        ShadePhong = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DSHADE_FORCE_DWORD")]
        ShadeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DSHADE_FLAT")]
        Flat = 0x1,
        [NativeName("Name", "D3DSHADE_GOURAUD")]
        Gouraud = 0x2,
        [NativeName("Name", "D3DSHADE_PHONG")]
        Phong = 0x3,
        [NativeName("Name", "D3DSHADE_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
