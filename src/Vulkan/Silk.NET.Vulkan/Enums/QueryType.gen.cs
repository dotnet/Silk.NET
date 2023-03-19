// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
        [NativeName("Name", "VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR")]
        ResultStatusOnlyKhr = 1000023000,
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
        [NativeName("Name", "VK_QUERY_TYPE_VIDEO_ENCODE_FEEDBACK_KHR")]
        VideoEncodeFeedbackKhr = 1000299000,
        [NativeName("Name", "VK_QUERY_TYPE_MESH_PRIMITIVES_GENERATED_EXT")]
        MeshPrimitivesGeneratedExt = 1000328000,
        [NativeName("Name", "VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT")]
        PrimitivesGeneratedExt = 1000382000,
        [NativeName("Name", "VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHR")]
        AccelerationStructureSerializationBottomLevelPointersKhr = 1000386000,
        [NativeName("Name", "VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR")]
        AccelerationStructureSizeKhr = 1000386001,
        [NativeName("Name", "VK_QUERY_TYPE_MICROMAP_SERIALIZATION_SIZE_EXT")]
        MicromapSerializationSizeExt = 1000396000,
        [NativeName("Name", "VK_QUERY_TYPE_MICROMAP_COMPACTED_SIZE_EXT")]
        MicromapCompactedSizeExt = 1000396001,
    }
}
