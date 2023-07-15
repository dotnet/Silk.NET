// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1"]/*'/>
public partial struct D3D12_QUERY_DATA_PIPELINE_STATISTICS1
{
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.IAVertices"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong IAVertices;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.IAPrimitives"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong IAPrimitives;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.VSInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong VSInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.GSInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong GSInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.GSPrimitives"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong GSPrimitives;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.CInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong CInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.CPrimitives"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong CPrimitives;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.PSInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong PSInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.HSInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong HSInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.DSInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong DSInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.CSInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong CSInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.ASInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong ASInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.MSInvocations"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong MSInvocations;
    /// <include file='D3D12_QUERY_DATA_PIPELINE_STATISTICS1.xml' path='doc/member[@name="D3D12_QUERY_DATA_PIPELINE_STATISTICS1.MSPrimitives"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong MSPrimitives;
}