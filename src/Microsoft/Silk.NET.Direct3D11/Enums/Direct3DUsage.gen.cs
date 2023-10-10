// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "Direct3DUsage")]
    public enum Direct3DUsage : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "Direct3DUsage_Default")]
        Direct3DUsageDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Immutable\"")]
        [NativeName("Name", "Direct3DUsage_Immutable")]
        Direct3DUsageImmutable = 0x1,
        [Obsolete("Deprecated in favour of \"Dynamic\"")]
        [NativeName("Name", "Direct3DUsage_Dynamic")]
        Direct3DUsageDynamic = 0x2,
        [Obsolete("Deprecated in favour of \"Staging\"")]
        [NativeName("Name", "Direct3DUsage_Staging")]
        Direct3DUsageStaging = 0x3,
        [NativeName("Name", "Direct3DUsage_Default")]
        Default = 0x0,
        [NativeName("Name", "Direct3DUsage_Immutable")]
        Immutable = 0x1,
        [NativeName("Name", "Direct3DUsage_Dynamic")]
        Dynamic = 0x2,
        [NativeName("Name", "Direct3DUsage_Staging")]
        Staging = 0x3,
    }
}
