// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "_DXGI_OFFER_RESOURCE_PRIORITY")]
    public enum OfferResourcePriority
    {
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_LOW")]
        OfferResourcePriorityLow = 0x1,
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_NORMAL")]
        OfferResourcePriorityNormal = 0x2,
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_HIGH")]
        OfferResourcePriorityHigh = 0x3,
    }
}
