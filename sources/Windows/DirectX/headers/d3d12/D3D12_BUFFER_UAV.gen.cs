// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_BUFFER_UAV.xml' path='doc/member[@name="D3D12_BUFFER_UAV"]/*' />
public partial struct D3D12_BUFFER_UAV
{
    /// <include file='D3D12_BUFFER_UAV.xml' path='doc/member[@name="D3D12_BUFFER_UAV.FirstElement"]/*' />
    [NativeTypeName("UINT64")]
    public ulong FirstElement;

    /// <include file='D3D12_BUFFER_UAV.xml' path='doc/member[@name="D3D12_BUFFER_UAV.NumElements"]/*' />
    public uint NumElements;

    /// <include file='D3D12_BUFFER_UAV.xml' path='doc/member[@name="D3D12_BUFFER_UAV.StructureByteStride"]/*' />
    public uint StructureByteStride;

    /// <include file='D3D12_BUFFER_UAV.xml' path='doc/member[@name="D3D12_BUFFER_UAV.CounterOffsetInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CounterOffsetInBytes;

    /// <include file='D3D12_BUFFER_UAV.xml' path='doc/member[@name="D3D12_BUFFER_UAV.Flags"]/*' />
    public D3D12_BUFFER_UAV_FLAGS Flags;
}
