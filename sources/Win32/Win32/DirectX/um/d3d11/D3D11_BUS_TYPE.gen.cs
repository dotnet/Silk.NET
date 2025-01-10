// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public enum D3D11_BUS_TYPE
{
    D3D11_BUS_TYPE_OTHER = 0,
    D3D11_BUS_TYPE_PCI = 0x1,
    D3D11_BUS_TYPE_PCIX = 0x2,
    D3D11_BUS_TYPE_PCIEXPRESS = 0x3,
    D3D11_BUS_TYPE_AGP = 0x4,
    D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET = 0x10000,
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x20000,
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x30000,
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x40000,
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x50000,
    D3D11_BUS_IMPL_MODIFIER_NON_STANDARD = unchecked((int)(0x80000000)),
}
