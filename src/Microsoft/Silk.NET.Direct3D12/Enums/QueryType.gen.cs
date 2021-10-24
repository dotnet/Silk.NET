// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_QUERY_TYPE")]
    public enum QueryType : int
    {
        [NativeName("Name", "D3D12_QUERY_TYPE_OCCLUSION")]
        QueryTypeOcclusion = 0x0,
        [NativeName("Name", "D3D12_QUERY_TYPE_BINARY_OCCLUSION")]
        QueryTypeBinaryOcclusion = 0x1,
        [NativeName("Name", "D3D12_QUERY_TYPE_TIMESTAMP")]
        QueryTypeTimestamp = 0x2,
        [NativeName("Name", "D3D12_QUERY_TYPE_PIPELINE_STATISTICS")]
        QueryTypePipelineStatistics = 0x3,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0")]
        QueryTypeSOStatisticsStream0 = 0x4,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1")]
        QueryTypeSOStatisticsStream1 = 0x5,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2")]
        QueryTypeSOStatisticsStream2 = 0x6,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3")]
        QueryTypeSOStatisticsStream3 = 0x7,
        [NativeName("Name", "D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS")]
        QueryTypeVideoDecodeStatistics = 0x8,
        [NativeName("Name", "D3D12_QUERY_TYPE_PIPELINE_STATISTICS1")]
        QueryTypePipelineStatistics1 = 0xA,
    }
}
