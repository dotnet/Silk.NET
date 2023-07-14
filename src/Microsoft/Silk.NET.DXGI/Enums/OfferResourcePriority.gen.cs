// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "_DXGI_OFFER_RESOURCE_PRIORITY")]
    public enum OfferResourcePriority : int
    {
        [Obsolete("Deprecated in favour of \"Low\"")]
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_LOW")]
        OfferResourcePriorityLow = 0x1,
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_NORMAL")]
        OfferResourcePriorityNormal = 0x2,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_HIGH")]
        OfferResourcePriorityHigh = 0x3,
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_LOW")]
        Low = 0x1,
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_NORMAL")]
        Normal = 0x2,
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_HIGH")]
        High = 0x3,
    }
}
