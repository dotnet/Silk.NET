// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_COPP_BusType")]
    public enum COPPBusType : int
    {
        [NativeName("Name", "COPP_BusType_Unknown")]
        CoppBusTypeUnknown = 0x0,
        [NativeName("Name", "COPP_BusType_PCI")]
        CoppBusTypePci = 0x1,
        [NativeName("Name", "COPP_BusType_PCIX")]
        CoppBusTypePcix = 0x2,
        [NativeName("Name", "COPP_BusType_PCIExpress")]
        CoppBusTypePciexpress = 0x3,
        [NativeName("Name", "COPP_BusType_AGP")]
        CoppBusTypeAgp = 0x4,
        [NativeName("Name", "COPP_BusType_Integrated")]
        CoppBusTypeIntegrated = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "COPP_BusType_ForceDWORD")]
        CoppBusTypeForceDword = 0x7FFFFFFF,
    }
}
