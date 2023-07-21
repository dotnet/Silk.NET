// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_DESCRIPTOR.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR"]/*' />
public partial struct D3D12_ROOT_DESCRIPTOR
{
    /// <include file='D3D12_ROOT_DESCRIPTOR.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR.ShaderRegister"]/*' />
    public uint ShaderRegister;

    /// <include file='D3D12_ROOT_DESCRIPTOR.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR.RegisterSpace"]/*' />
    public uint RegisterSpace;
}
