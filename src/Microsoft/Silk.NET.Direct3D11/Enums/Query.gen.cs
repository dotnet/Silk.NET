// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_QUERY")]
    public enum Query
    {
        [NativeName("Name", "D3D11_QUERY_EVENT")]
        QueryEvent = 0x0,
        [NativeName("Name", "D3D11_QUERY_OCCLUSION")]
        QueryOcclusion = 0x1,
        [NativeName("Name", "D3D11_QUERY_TIMESTAMP")]
        QueryTimestamp = 0x2,
        [NativeName("Name", "D3D11_QUERY_TIMESTAMP_DISJOINT")]
        QueryTimestampDisjoint = 0x3,
        [NativeName("Name", "D3D11_QUERY_PIPELINE_STATISTICS")]
        QueryPipelineStatistics = 0x4,
        [NativeName("Name", "D3D11_QUERY_OCCLUSION_PREDICATE")]
        QueryOcclusionPredicate = 0x5,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS")]
        QuerySOStatistics = 0x6,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE")]
        QuerySOOverflowPredicate = 0x7,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM0")]
        QuerySOStatisticsStream0 = 0x8,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0")]
        QuerySOOverflowPredicateStream0 = 0x9,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM1")]
        QuerySOStatisticsStream1 = 0xA,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1")]
        QuerySOOverflowPredicateStream1 = 0xB,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM2")]
        QuerySOStatisticsStream2 = 0xC,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2")]
        QuerySOOverflowPredicateStream2 = 0xD,
        [NativeName("Name", "D3D11_QUERY_SO_STATISTICS_STREAM3")]
        QuerySOStatisticsStream3 = 0xE,
        [NativeName("Name", "D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM3")]
        QuerySOOverflowPredicateStream3 = 0xF,
    }
}
