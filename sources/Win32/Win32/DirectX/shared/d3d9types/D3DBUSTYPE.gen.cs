// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3DBUSTYPE
{
    D3DBUSTYPE_OTHER = 0x00000000,
    D3DBUSTYPE_PCI = 0x00000001,
    D3DBUSTYPE_PCIX = 0x00000002,
    D3DBUSTYPE_PCIEXPRESS = 0x00000003,
    D3DBUSTYPE_AGP = 0x00000004,
    D3DBUSIMPL_MODIFIER_INSIDE_OF_CHIPSET = 0x00010000,
    D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x00020000,
    D3DBUSIMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x00030000,
    D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x00040000,
    D3DBUSIMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x00050000,
    D3DBUSIMPL_MODIFIER_NON_STANDARD = unchecked((int)(0x80000000)),
}
