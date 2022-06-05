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
        [Obsolete("Deprecated in favour of \"Occlusion\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_OCCLUSION")]
        QueryTypeOcclusion = 0x0,
        [Obsolete("Deprecated in favour of \"BinaryOcclusion\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_BINARY_OCCLUSION")]
        QueryTypeBinaryOcclusion = 0x1,
        [Obsolete("Deprecated in favour of \"Timestamp\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_TIMESTAMP")]
        QueryTypeTimestamp = 0x2,
        [Obsolete("Deprecated in favour of \"PipelineStatistics\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_PIPELINE_STATISTICS")]
        QueryTypePipelineStatistics = 0x3,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream0\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0")]
        QueryTypeSOStatisticsStream0 = 0x4,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream1\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1")]
        QueryTypeSOStatisticsStream1 = 0x5,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream2\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2")]
        QueryTypeSOStatisticsStream2 = 0x6,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream3\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3")]
        QueryTypeSOStatisticsStream3 = 0x7,
        [Obsolete("Deprecated in favour of \"VideoDecodeStatistics\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS")]
        QueryTypeVideoDecodeStatistics = 0x8,
        [Obsolete("Deprecated in favour of \"PipelineStatistics1\"")]
        [NativeName("Name", "D3D12_QUERY_TYPE_PIPELINE_STATISTICS1")]
        QueryTypePipelineStatistics1 = 0xA,
        [NativeName("Name", "D3D12_QUERY_TYPE_OCCLUSION")]
        Occlusion = 0x0,
        [NativeName("Name", "D3D12_QUERY_TYPE_BINARY_OCCLUSION")]
        BinaryOcclusion = 0x1,
        [NativeName("Name", "D3D12_QUERY_TYPE_TIMESTAMP")]
        Timestamp = 0x2,
        [NativeName("Name", "D3D12_QUERY_TYPE_PIPELINE_STATISTICS")]
        PipelineStatistics = 0x3,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0")]
        SOStatisticsStream0 = 0x4,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1")]
        SOStatisticsStream1 = 0x5,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2")]
        SOStatisticsStream2 = 0x6,
        [NativeName("Name", "D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3")]
        SOStatisticsStream3 = 0x7,
        [NativeName("Name", "D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS")]
        VideoDecodeStatistics = 0x8,
        [NativeName("Name", "D3D12_QUERY_TYPE_PIPELINE_STATISTICS1")]
        PipelineStatistics1 = 0xA,
    }
}
