// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueryType")]
    public enum QueryType : int
    {
        [NativeName("Name", "VK_QUERY_TYPE_OCCLUSION")]
        Occlusion = 0,
        [NativeName("Name", "VK_QUERY_TYPE_PIPELINE_STATISTICS")]
        PipelineStatistics = 1,
        [NativeName("Name", "VK_QUERY_TYPE_TIMESTAMP")]
        Timestamp = 2,
        [NativeName("Name", "VK_QUERY_TYPE_RESERVED_8")]
        Reserved8 = 1000023008,
        [NativeName("Name", "VK_QUERY_TYPE_RESERVED_4")]
        Reserved4 = 1000024004,
        [NativeName("Name", "VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT")]
        TransformFeedbackStreamExt = 1000028004,
        [NativeName("Name", "VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR")]
        PerformanceQueryKhr = 1000116000,
        [NativeName("Name", "VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR")]
        AccelerationStructureCompactedSizeKhr = 1000150000,
        [NativeName("Name", "VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR")]
        AccelerationStructureSerializationSizeKhr = 1000150001,
        [NativeName("Name", "VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV")]
        AccelerationStructureCompactedSizeNV = 1000165000,
        [NativeName("Name", "VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL")]
        PerformanceQueryIntel = 1000210000,
    }
}
