// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum D3D11_BUS_TYPE
{
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_OTHER"]/*'/>
    D3D11_BUS_TYPE_OTHER = 0,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_PCI"]/*'/>
    D3D11_BUS_TYPE_PCI = 0x1,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_PCIX"]/*'/>
    D3D11_BUS_TYPE_PCIX = 0x2,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_PCIEXPRESS"]/*'/>
    D3D11_BUS_TYPE_PCIEXPRESS = 0x3,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_TYPE_AGP"]/*'/>
    D3D11_BUS_TYPE_AGP = 0x4,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET"]/*'/>
    D3D11_BUS_IMPL_MODIFIER_INSIDE_OF_CHIPSET = 0x10000,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP"]/*'/>
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x20000,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET"]/*'/>
    D3D11_BUS_IMPL_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x30000,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR"]/*'/>
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x40000,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE"]/*'/>
    D3D11_BUS_IMPL_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x50000,
    /// <include file='D3D11_BUS_TYPE.xml' path='doc/member[@name="D3D11_BUS_TYPE.D3D11_BUS_IMPL_MODIFIER_NON_STANDARD"]/*'/>
    D3D11_BUS_IMPL_MODIFIER_NON_STANDARD = unchecked((int)(0x80000000)),
}