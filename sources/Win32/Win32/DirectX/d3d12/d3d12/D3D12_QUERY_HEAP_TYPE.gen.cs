// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_QUERY_HEAP_TYPE
{
    D3D12_QUERY_HEAP_TYPE_OCCLUSION = 0,
    D3D12_QUERY_HEAP_TYPE_TIMESTAMP = 1,
    D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS = 2,
    D3D12_QUERY_HEAP_TYPE_SO_STATISTICS = 3,
    D3D12_QUERY_HEAP_TYPE_VIDEO_DECODE_STATISTICS = 4,
    D3D12_QUERY_HEAP_TYPE_COPY_QUEUE_TIMESTAMP = 5,
    D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS1 = 7,
}
