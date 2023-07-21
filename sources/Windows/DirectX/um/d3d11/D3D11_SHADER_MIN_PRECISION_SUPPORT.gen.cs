// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_SHADER_MIN_PRECISION_SUPPORT.xml' path='doc/member[@name="D3D11_SHADER_MIN_PRECISION_SUPPORT"]/*' />
public enum D3D11_SHADER_MIN_PRECISION_SUPPORT
{
    /// <include file='D3D11_SHADER_MIN_PRECISION_SUPPORT.xml' path='doc/member[@name="D3D11_SHADER_MIN_PRECISION_SUPPORT.D3D11_SHADER_MIN_PRECISION_10_BIT"]/*' />
    D3D11_SHADER_MIN_PRECISION_10_BIT = 0x1,

    /// <include file='D3D11_SHADER_MIN_PRECISION_SUPPORT.xml' path='doc/member[@name="D3D11_SHADER_MIN_PRECISION_SUPPORT.D3D11_SHADER_MIN_PRECISION_16_BIT"]/*' />
    D3D11_SHADER_MIN_PRECISION_16_BIT = 0x2,
}
