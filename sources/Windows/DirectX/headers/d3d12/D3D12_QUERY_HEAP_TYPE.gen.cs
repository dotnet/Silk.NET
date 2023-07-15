// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE"]/*'/>
public enum D3D12_QUERY_HEAP_TYPE
{
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_OCCLUSION"]/*'/>
    D3D12_QUERY_HEAP_TYPE_OCCLUSION = 0,
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_TIMESTAMP"]/*'/>
    D3D12_QUERY_HEAP_TYPE_TIMESTAMP = 1,
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS"]/*'/>
    D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS = 2,
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_SO_STATISTICS"]/*'/>
    D3D12_QUERY_HEAP_TYPE_SO_STATISTICS = 3,
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_VIDEO_DECODE_STATISTICS"]/*'/>
    D3D12_QUERY_HEAP_TYPE_VIDEO_DECODE_STATISTICS = 4,
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_COPY_QUEUE_TIMESTAMP"]/*'/>
    D3D12_QUERY_HEAP_TYPE_COPY_QUEUE_TIMESTAMP = 5,
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS1"]/*'/>
    D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS1 = 7,
}