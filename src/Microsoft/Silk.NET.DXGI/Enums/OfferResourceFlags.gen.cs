// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "_DXGI_OFFER_RESOURCE_FLAGS")]
    public enum OfferResourceFlags : int
    {
        [NativeName("Name", "DXGI_OFFER_RESOURCE_FLAG_ALLOW_DECOMMIT")]
        OfferResourceFlagAllowDecommit = 0x1,
    }
}
