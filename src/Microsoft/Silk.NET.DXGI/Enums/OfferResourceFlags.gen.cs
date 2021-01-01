// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
