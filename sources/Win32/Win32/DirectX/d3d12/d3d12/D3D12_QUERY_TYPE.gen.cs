// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_QUERY_TYPE
{
    D3D12_QUERY_TYPE_OCCLUSION = 0,
    D3D12_QUERY_TYPE_BINARY_OCCLUSION = 1,
    D3D12_QUERY_TYPE_TIMESTAMP = 2,
    D3D12_QUERY_TYPE_PIPELINE_STATISTICS = 3,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0 = 4,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1 = 5,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2 = 6,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3 = 7,
    D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS = 8,
    D3D12_QUERY_TYPE_PIPELINE_STATISTICS1 = 10,
}
