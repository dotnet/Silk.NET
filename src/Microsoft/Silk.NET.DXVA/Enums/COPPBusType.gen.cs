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
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "COPP_BusType_Unknown")]
        CoppBusTypeUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Pci\"")]
        [NativeName("Name", "COPP_BusType_PCI")]
        CoppBusTypePci = 0x1,
        [Obsolete("Deprecated in favour of \"Pcix\"")]
        [NativeName("Name", "COPP_BusType_PCIX")]
        CoppBusTypePcix = 0x2,
        [Obsolete("Deprecated in favour of \"PciExpress\"")]
        [NativeName("Name", "COPP_BusType_PCIExpress")]
        CoppBusTypePciexpress = 0x3,
        [Obsolete("Deprecated in favour of \"Agp\"")]
        [NativeName("Name", "COPP_BusType_AGP")]
        CoppBusTypeAgp = 0x4,
        [Obsolete("Deprecated in favour of \"Integrated\"")]
        [NativeName("Name", "COPP_BusType_Integrated")]
        CoppBusTypeIntegrated = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "COPP_BusType_ForceDWORD")]
        CoppBusTypeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "COPP_BusType_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "COPP_BusType_PCI")]
        Pci = 0x1,
        [NativeName("Name", "COPP_BusType_PCIX")]
        Pcix = 0x2,
        [NativeName("Name", "COPP_BusType_PCIExpress")]
        PciExpress = 0x3,
        [NativeName("Name", "COPP_BusType_AGP")]
        Agp = 0x4,
        [NativeName("Name", "COPP_BusType_Integrated")]
        Integrated = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "COPP_BusType_ForceDWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
