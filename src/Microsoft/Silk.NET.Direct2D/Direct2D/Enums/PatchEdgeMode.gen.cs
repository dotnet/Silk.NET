// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_PATCH_EDGE_MODE")]
    public enum PatchEdgeMode : int
    {
        [NativeName("Name", "D2D1_PATCH_EDGE_MODE_ALIASED")]
        Aliased = 0x0,
        [NativeName("Name", "D2D1_PATCH_EDGE_MODE_ANTIALIASED")]
        Antialiased = 0x1,
        [NativeName("Name", "D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED")]
        AliasedInflated = 0x2,
        [NativeName("Name", "D2D1_PATCH_EDGE_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
