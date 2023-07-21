// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA
{
    /// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.HWProtectionFunctionID"]/*' />
    public uint HWProtectionFunctionID;

    /// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.pInputData"]/*' />
    public D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA* pInputData;

    /// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.pOutputData"]/*' />
    public D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA* pOutputData;

    /// <include file='D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.xml' path='doc/member[@name="D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA.Status"]/*' />
    public HRESULT Status;
}
