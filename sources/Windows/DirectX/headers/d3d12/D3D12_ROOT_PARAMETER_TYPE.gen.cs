// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE"]/*' />
public enum D3D12_ROOT_PARAMETER_TYPE
{
    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE"]/*' />
    D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE = 0,

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS"]/*' />
    D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS = (D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE + 1),

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_CBV"]/*' />
    D3D12_ROOT_PARAMETER_TYPE_CBV = (D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS + 1),

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_SRV"]/*' />
    D3D12_ROOT_PARAMETER_TYPE_SRV = (D3D12_ROOT_PARAMETER_TYPE_CBV + 1),

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_UAV"]/*' />
    D3D12_ROOT_PARAMETER_TYPE_UAV = (D3D12_ROOT_PARAMETER_TYPE_SRV + 1),
}
