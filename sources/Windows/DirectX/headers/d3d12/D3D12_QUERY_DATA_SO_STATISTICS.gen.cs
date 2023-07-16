// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_QUERY_DATA_SO_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_SO_STATISTICS"]/*'/>
public partial struct D3D12_QUERY_DATA_SO_STATISTICS
{
    /// <include file='D3D12_QUERY_DATA_SO_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_SO_STATISTICS.NumPrimitivesWritten"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong NumPrimitivesWritten;
    /// <include file='D3D12_QUERY_DATA_SO_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_SO_STATISTICS.PrimitivesStorageNeeded"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong PrimitivesStorageNeeded;
}