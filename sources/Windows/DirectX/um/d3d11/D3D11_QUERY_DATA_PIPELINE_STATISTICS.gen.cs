// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS"]/*' />
public partial struct D3D11_QUERY_DATA_PIPELINE_STATISTICS
{
    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.IAVertices"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IAVertices;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.IAPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IAPrimitives;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.VSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VSInvocations;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.GSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong GSInvocations;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.GSPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong GSPrimitives;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.CInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CInvocations;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.CPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CPrimitives;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.PSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong PSInvocations;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.HSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong HSInvocations;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.DSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong DSInvocations;

    /// <include file='D3D11_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_PIPELINE_STATISTICS.CSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CSInvocations;
}
