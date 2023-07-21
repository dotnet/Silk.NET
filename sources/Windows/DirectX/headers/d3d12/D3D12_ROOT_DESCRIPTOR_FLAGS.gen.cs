// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_DESCRIPTOR_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR_FLAGS"]/*' />
[Flags]
public enum D3D12_ROOT_DESCRIPTOR_FLAGS
{
    /// <include file='D3D12_ROOT_DESCRIPTOR_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR_FLAGS.D3D12_ROOT_DESCRIPTOR_FLAG_NONE"]/*' />
    D3D12_ROOT_DESCRIPTOR_FLAG_NONE = 0,

    /// <include file='D3D12_ROOT_DESCRIPTOR_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR_FLAGS.D3D12_ROOT_DESCRIPTOR_FLAG_DATA_VOLATILE"]/*' />
    D3D12_ROOT_DESCRIPTOR_FLAG_DATA_VOLATILE = 0x2,

    /// <include file='D3D12_ROOT_DESCRIPTOR_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR_FLAGS.D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE"]/*' />
    D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE = 0x4,

    /// <include file='D3D12_ROOT_DESCRIPTOR_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR_FLAGS.D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC"]/*' />
    D3D12_ROOT_DESCRIPTOR_FLAG_DATA_STATIC = 0x8,
}
