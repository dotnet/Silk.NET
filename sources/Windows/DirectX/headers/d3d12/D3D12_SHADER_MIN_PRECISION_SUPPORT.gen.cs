// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_MIN_PRECISION_SUPPORT.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT"]/*' />
[Flags]
public enum D3D12_SHADER_MIN_PRECISION_SUPPORT
{
    /// <include file='D3D12_SHADER_MIN_PRECISION_SUPPORT.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT.D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE"]/*' />
    D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE = 0,

    /// <include file='D3D12_SHADER_MIN_PRECISION_SUPPORT.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT.D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT"]/*' />
    D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT = 0x1,

    /// <include file='D3D12_SHADER_MIN_PRECISION_SUPPORT.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT.D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT"]/*' />
    D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT = 0x2,
}
