// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum QueryType
    {
        Occlusion = 0,
        PipelineStatistics = 1,
        Timestamp = 2,
        Reserved8 = 1000023008,
        Reserved4 = 1000024004,
        TransformFeedbackStreamExt = 1000028004,
        PerformanceQueryKhr = 1000116000,
        AccelerationStructureCompactedSizeKhr = 1000165000,
        AccelerationStructureSerializationSizeKhr = 1000150000,
        AccelerationStructureCompactedSizeNV = 1000165000,
        PerformanceQueryIntel = 1000210000,
    }
}
