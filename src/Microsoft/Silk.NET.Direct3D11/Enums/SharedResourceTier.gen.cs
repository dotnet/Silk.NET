// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER")]
    public enum SharedResourceTier : int
    {
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_0")]
        SharedResourceTier0 = 0x0,
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_1")]
        SharedResourceTier1 = 0x1,
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_2")]
        SharedResourceTier2 = 0x2,
        [NativeName("Name", "D3D11_SHARED_RESOURCE_TIER_3")]
        SharedResourceTier3 = 0x3,
    }
}
