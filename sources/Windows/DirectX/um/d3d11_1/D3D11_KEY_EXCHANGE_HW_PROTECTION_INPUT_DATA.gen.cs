// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA
{
    /// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA.PrivateDataSize"]/*'/>
    public uint PrivateDataSize;
    /// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA.HWProtectionDataSize"]/*'/>
    public uint HWProtectionDataSize;
    /// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA.pbInput"]/*'/>
    [NativeTypeName("BYTE[4]")]
    public fixed byte pbInput[4];
}