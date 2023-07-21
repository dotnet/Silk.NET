// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS"]/*' />
public partial struct D3D12_QUERY_DATA_PIPELINE_STATISTICS
{
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.IAVertices"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IAVertices;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.IAPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IAPrimitives;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.VSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VSInvocations;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.GSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong GSInvocations;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.GSPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong GSPrimitives;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.CInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CInvocations;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.CPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CPrimitives;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.PSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong PSInvocations;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.HSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong HSInvocations;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.DSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong DSInvocations;

    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS.CSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CSInvocations;
}
