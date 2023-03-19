// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_USAGE")]
    public enum Usage : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D3D11_USAGE_DEFAULT")]
        UsageDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Immutable\"")]
        [NativeName("Name", "D3D11_USAGE_IMMUTABLE")]
        UsageImmutable = 0x1,
        [Obsolete("Deprecated in favour of \"Dynamic\"")]
        [NativeName("Name", "D3D11_USAGE_DYNAMIC")]
        UsageDynamic = 0x2,
        [Obsolete("Deprecated in favour of \"Staging\"")]
        [NativeName("Name", "D3D11_USAGE_STAGING")]
        UsageStaging = 0x3,
        [NativeName("Name", "D3D11_USAGE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D3D11_USAGE_IMMUTABLE")]
        Immutable = 0x1,
        [NativeName("Name", "D3D11_USAGE_DYNAMIC")]
        Dynamic = 0x2,
        [NativeName("Name", "D3D11_USAGE_STAGING")]
        Staging = 0x3,
    }
}
