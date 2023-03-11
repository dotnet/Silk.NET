// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_BUS_TYPE")]
    public enum BusType : int
    {
        [Obsolete("Deprecated in favour of \"TypeOther\"")]
        [NativeName("Name", "D3D11_BUS_TYPE_OTHER")]
        BusTypeOther = 0x0,
        [Obsolete("Deprecated in favour of \"TypePci\"")]
        [NativeName("Name", "D3D11_BUS_TYPE_PCI")]
        BusTypePci = 0x1,
        [Obsolete("Deprecated in favour of \"TypePcix\"")]
        [NativeName("Name", "D3D11_BUS_TYPE_PCIX")]
        BusTypePcix = 0x2,
        [Obsolete("Deprecated in favour of \"TypePciexpress\"")]
        [NativeName("Name", "D3D11_BUS_TYPE_PCIEXPRESS")]
        BusTypePciexpress = 0x3,
        [Obsolete("Deprecated in favour of \"TypeAgp\"")]
        [NativeName("Name", "D3D11_BUS_TYPE_AGP")]
        BusTypeAgp = 0x4,
        [Obsolete("Deprecated in favour of \"ImplModifierInsideOfChipset\"")]
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET")]
        BusImplModifierInsideOfChipset = 0x10000,
        [Obsolete("Deprecated in favour of \"ImplModifierTracksOnMotherBoardToChip\"")]
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP")]
        BusImplModifierTracksOnMotherBoardToChip = 0x20000,
        [Obsolete("Deprecated in favour of \"ImplModifierTracksOnMotherBoardToSocket\"")]
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET")]
        BusImplModifierTracksOnMotherBoardToSocket = 0x30000,
        [Obsolete("Deprecated in favour of \"ImplModifierDaughterBoardConnector\"")]
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR")]
        BusImplModifierDaughterBoardConnector = 0x40000,
        [Obsolete("Deprecated in favour of \"ImplModifierDaughterBoardConnectorInsideOfNuae\"")]
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE")]
        BusImplModifierDaughterBoardConnectorInsideOfNuae = 0x50000,
        [Obsolete("Deprecated in favour of \"ImplModifierNonStandard\"")]
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_NON_STANDARD")]
        BusImplModifierNonStandard = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D3D11_BUS_TYPE_OTHER")]
        TypeOther = 0x0,
        [NativeName("Name", "D3D11_BUS_TYPE_PCI")]
        TypePci = 0x1,
        [NativeName("Name", "D3D11_BUS_TYPE_PCIX")]
        TypePcix = 0x2,
        [NativeName("Name", "D3D11_BUS_TYPE_PCIEXPRESS")]
        TypePciexpress = 0x3,
        [NativeName("Name", "D3D11_BUS_TYPE_AGP")]
        TypeAgp = 0x4,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET")]
        ImplModifierInsideOfChipset = 0x10000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP")]
        ImplModifierTracksOnMotherBoardToChip = 0x20000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET")]
        ImplModifierTracksOnMotherBoardToSocket = 0x30000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR")]
        ImplModifierDaughterBoardConnector = 0x40000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE")]
        ImplModifierDaughterBoardConnectorInsideOfNuae = 0x50000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_NON_STANDARD")]
        ImplModifierNonStandard = unchecked((int) 0xFFFFFFFF80000000),
    }
}
