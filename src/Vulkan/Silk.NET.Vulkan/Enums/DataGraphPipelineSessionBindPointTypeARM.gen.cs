// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDataGraphPipelineSessionBindPointTypeARM")]
    public enum DataGraphPipelineSessionBindPointTypeARM : int
    {
        [Obsolete("Deprecated in favour of \"MemoryArm\"")]
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TYPE_MEMORY_ARM")]
        DataGraphPipelineSessionBindPointTypeMemoryArm = 0,
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TYPE_MEMORY_ARM")]
        MemoryArm = 0,
    }
}
