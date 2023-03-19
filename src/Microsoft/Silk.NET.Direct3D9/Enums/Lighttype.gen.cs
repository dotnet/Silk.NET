// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DLIGHTTYPE")]
    public enum Lighttype : int
    {
        [Obsolete("Deprecated in favour of \"Point\"")]
        [NativeName("Name", "D3DLIGHT_POINT")]
        LightPoint = 0x1,
        [Obsolete("Deprecated in favour of \"Spot\"")]
        [NativeName("Name", "D3DLIGHT_SPOT")]
        LightSpot = 0x2,
        [Obsolete("Deprecated in favour of \"Directional\"")]
        [NativeName("Name", "D3DLIGHT_DIRECTIONAL")]
        LightDirectional = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DLIGHT_FORCE_DWORD")]
        LightForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DLIGHT_POINT")]
        Point = 0x1,
        [NativeName("Name", "D3DLIGHT_SPOT")]
        Spot = 0x2,
        [NativeName("Name", "D3DLIGHT_DIRECTIONAL")]
        Directional = 0x3,
        [NativeName("Name", "D3DLIGHT_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
