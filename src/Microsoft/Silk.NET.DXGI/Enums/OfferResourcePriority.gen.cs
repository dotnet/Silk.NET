// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "_DXGI_OFFER_RESOURCE_PRIORITY")]
    public enum OfferResourcePriority : int
    {
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_LOW")]
        OfferResourcePriorityLow = 0x1,
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_NORMAL")]
        OfferResourcePriorityNormal = 0x2,
        [NativeName("Name", "DXGI_OFFER_RESOURCE_PRIORITY_HIGH")]
        OfferResourcePriorityHigh = 0x3,
    }
}
