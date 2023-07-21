// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_HEAP_DESC.xml' path='doc/member[@name="D3D12_HEAP_DESC"]/*' />
public partial struct D3D12_HEAP_DESC
{
    /// <include file='D3D12_HEAP_DESC.xml' path='doc/member[@name="D3D12_HEAP_DESC.SizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SizeInBytes;

    /// <include file='D3D12_HEAP_DESC.xml' path='doc/member[@name="D3D12_HEAP_DESC.Properties"]/*' />
    public D3D12_HEAP_PROPERTIES Properties;

    /// <include file='D3D12_HEAP_DESC.xml' path='doc/member[@name="D3D12_HEAP_DESC.Alignment"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Alignment;

    /// <include file='D3D12_HEAP_DESC.xml' path='doc/member[@name="D3D12_HEAP_DESC.Flags"]/*' />
    public D3D12_HEAP_FLAGS Flags;
}
