// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE"]/*'/>
public enum D3D12_QUERY_TYPE
{
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_OCCLUSION"]/*'/>
    D3D12_QUERY_TYPE_OCCLUSION = 0,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_BINARY_OCCLUSION"]/*'/>
    D3D12_QUERY_TYPE_BINARY_OCCLUSION = 1,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_TIMESTAMP"]/*'/>
    D3D12_QUERY_TYPE_TIMESTAMP = 2,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_PIPELINE_STATISTICS"]/*'/>
    D3D12_QUERY_TYPE_PIPELINE_STATISTICS = 3,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0"]/*'/>
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0 = 4,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1"]/*'/>
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1 = 5,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2"]/*'/>
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2 = 6,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3"]/*'/>
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3 = 7,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS"]/*'/>
    D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS = 8,
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_PIPELINE_STATISTICS1"]/*'/>
    D3D12_QUERY_TYPE_PIPELINE_STATISTICS1 = 10,
}