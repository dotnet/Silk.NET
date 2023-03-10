// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DBUSTYPE")]
    public enum Bustype : int
    {
        [NativeName("Name", "D3DBUSTYPE_OTHER")]
        BustypeOther = 0x0,
        [NativeName("Name", "D3DBUSTYPE_PCI")]
        BustypePci = 0x1,
        [NativeName("Name", "D3DBUSTYPE_PCIX")]
        BustypePcix = 0x2,
        [NativeName("Name", "D3DBUSTYPE_PCIEXPRESS")]
        BustypePciexpress = 0x3,
        [NativeName("Name", "D3DBUSTYPE_AGP")]
        BustypeAgp = 0x4,
        [NativeName("Name", "D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET")]
        BusimplModifierInsideOfChipset = 0x10000,
        [NativeName("Name", "D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP")]
        BusimplModifierTracksOnMotherBoardToChip = 0x20000,
        [NativeName("Name", "D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET")]
        BusimplModifierTracksOnMotherBoardToSocket = 0x30000,
        [NativeName("Name", "D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR")]
        BusimplModifierDaughterBoardConnector = 0x40000,
        [NativeName("Name", "D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE")]
        BusimplModifierDaughterBoardConnectorInsideOfNuae = 0x50000,
        [NativeName("Name", "D3DBUSIMPL_MODIFIER_NON_STANDARD")]
        BusimplModifierNonStandard = unchecked((int) 0xFFFFFFFF80000000),
    }
}
