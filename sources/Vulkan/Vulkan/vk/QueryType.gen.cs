// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueryType")]
public enum QueryType : uint
{
    [NativeName("VK_QUERY_TYPE_OCCLUSION")]
    Occlusion = 0,

    [NativeName("VK_QUERY_TYPE_PIPELINE_STATISTICS")]
    PipelineStatistics = 1,

    [NativeName("VK_QUERY_TYPE_TIMESTAMP")]
    Timestamp = 2,

    [NativeName("VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR")]
    ResultStatusOnlyKHR = 1000023000,

    [NativeName("VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT")]
    TransformFeedbackStreamEXT = 1000028004,

    [NativeName("VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR")]
    PerformanceQueryKHR = 1000116000,

    [NativeName("VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR")]
    AccelerationStructureCompactedSizeKHR = 1000150000,

    [NativeName("VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR")]
    AccelerationStructureSerializationSizeKHR = 1000150001,

    [NativeName("VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV")]
    AccelerationStructureCompactedSizeNV = 1000165000,

    [NativeName("VK_QUERY_TYPE_TIME_ELAPSED_QCOM")]
    TimeElapsedQCOM = 1000173000,

    [NativeName("VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL")]
    PerformanceQueryINTEL = 1000210000,

    [NativeName("VK_QUERY_TYPE_VIDEO_ENCODE_FEEDBACK_KHR")]
    VideoEncodeFeedbackKHR = 1000299000,

    [NativeName("VK_QUERY_TYPE_MESH_PRIMITIVES_GENERATED_EXT")]
    MeshPrimitivesGeneratedEXT = 1000328000,

    [NativeName("VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT")]
    PrimitivesGeneratedEXT = 1000382000,

    [NativeName("VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHR")]
    AccelerationStructureSerializationBottomLevelPointersKHR = 1000386000,

    [NativeName("VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR")]
    AccelerationStructureSizeKHR = 1000386001,

    [NativeName("VK_QUERY_TYPE_MICROMAP_SERIALIZATION_SIZE_EXT")]
    MicromapSerializationSizeEXT = 1000396000,

    [NativeName("VK_QUERY_TYPE_MICROMAP_COMPACTED_SIZE_EXT")]
    MicromapCompactedSizeEXT = 1000396001,
}
