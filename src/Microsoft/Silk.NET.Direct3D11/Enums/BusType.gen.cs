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
        [NativeName("Name", "D3D11_BUS_TYPE_OTHER")]
        BusTypeOther = 0x0,
        [NativeName("Name", "D3D11_BUS_TYPE_PCI")]
        BusTypePci = 0x1,
        [NativeName("Name", "D3D11_BUS_TYPE_PCIX")]
        BusTypePcix = 0x2,
        [NativeName("Name", "D3D11_BUS_TYPE_PCIEXPRESS")]
        BusTypePciexpress = 0x3,
        [NativeName("Name", "D3D11_BUS_TYPE_AGP")]
        BusTypeAgp = 0x4,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET")]
        BusImplModifierInsideOfChipset = 0x10000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP")]
        BusImplModifierTracksOnMotherBoardToChip = 0x20000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET")]
        BusImplModifierTracksOnMotherBoardToSocket = 0x30000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR")]
        BusImplModifierDaughterBoardConnector = 0x40000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE")]
        BusImplModifierDaughterBoardConnectorInsideOfNuae = 0x50000,
        [NativeName("Name", "D3D11_BUS_IMPL_MODIFIER_NON_STANDARD")]
        BusImplModifierNonStandard = unchecked((int) 0xFFFFFFFF80000000),
    }
}
