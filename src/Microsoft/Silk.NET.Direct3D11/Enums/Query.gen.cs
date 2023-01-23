// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_QUERY")]
    public enum Query : int
    {
        [Obsolete("Deprecated in favour of \"Event\"")]
        [NativeName("Name", "D3D11_QUERY_EVENT")]
        QueryEvent = 0x0,
        [Obsolete("Deprecated in favour of \"Occlusion\"")]
        [NativeName("Name", "D3D11_QUERY_OCCLUSION")]
        QueryOcclusion = 0x1,
        [Obsolete("Deprecated in favour of \"Timestamp\"")]
        [NativeName("Name", "D3D11_QUERY_TIMESTAMP")]
        QueryTimestamp = 0x2,
        [Obsolete("Deprecated in favour of \"TimestampDisjoint\"")]
        [NativeName("Name", "D3D11_QUERY_TIMESTAMP_DISJOINT")]
        QueryTimestampDisjoint = 0x3,
        [Obsolete("Deprecated in favour of \"PipelineStatistics\"")]
        [NativeName("Name", "D3D11_QUERY_PIPELINE_STATISTICS")]
        QueryPipelineStatistics = 0x4,
        [Obsolete("Deprecated in favour of \"OcclusionPredicate\"")]
        [NativeName("Name", "D3D11_QUERY_OCCLUSION_PREDICATE")]
        QueryOcclusionPredicate = 0x5,
        [Obsolete("Deprecated in favour of \"SOStatistics\"")]
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS")]
        QuerySOStatistics = 0x6,
        [Obsolete("Deprecated in favour of \"SOOverflowPredicate\"")]
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE")]
        QuerySOOverflowPredicate = 0x7,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream0\"")]
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM0")]
        QuerySOStatisticsStream0 = 0x8,
        [Obsolete("Deprecated in favour of \"SOOverflowPredicateStream0\"")]
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0")]
        QuerySOOverflowPredicateStream0 = 0x9,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream1\"")]
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM1")]
        QuerySOStatisticsStream1 = 0xA,
        [Obsolete("Deprecated in favour of \"SOOverflowPredicateStream1\"")]
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1")]
        QuerySOOverflowPredicateStream1 = 0xB,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream2\"")]
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM2")]
        QuerySOStatisticsStream2 = 0xC,
        [Obsolete("Deprecated in favour of \"SOOverflowPredicateStream2\"")]
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2")]
        QuerySOOverflowPredicateStream2 = 0xD,
        [Obsolete("Deprecated in favour of \"SOStatisticsStream3\"")]
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM3")]
        QuerySOStatisticsStream3 = 0xE,
        [Obsolete("Deprecated in favour of \"SOOverflowPredicateStream3\"")]
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM3")]
        QuerySOOverflowPredicateStream3 = 0xF,
        [NativeName("Name", "D3D11_QUERY_EVENT")]
        Event = 0x0,
        [NativeName("Name", "D3D11_QUERY_OCCLUSION")]
        Occlusion = 0x1,
        [NativeName("Name", "D3D11_QUERY_TIMESTAMP")]
        Timestamp = 0x2,
        [NativeName("Name", "D3D11_QUERY_TIMESTAMP_DISJOINT")]
        TimestampDisjoint = 0x3,
        [NativeName("Name", "D3D11_QUERY_PIPELINE_STATISTICS")]
        PipelineStatistics = 0x4,
        [NativeName("Name", "D3D11_QUERY_OCCLUSION_PREDICATE")]
        OcclusionPredicate = 0x5,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS")]
        SOStatistics = 0x6,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE")]
        SOOverflowPredicate = 0x7,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM0")]
        SOStatisticsStream0 = 0x8,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0")]
        SOOverflowPredicateStream0 = 0x9,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM1")]
        SOStatisticsStream1 = 0xA,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1")]
        SOOverflowPredicateStream1 = 0xB,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM2")]
        SOStatisticsStream2 = 0xC,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2")]
        SOOverflowPredicateStream2 = 0xD,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM3")]
        SOStatisticsStream3 = 0xE,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM3")]
        SOOverflowPredicateStream3 = 0xF,
    }
}
