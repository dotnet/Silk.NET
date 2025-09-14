// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDataGraphPipelineSessionBindPointARM")]
    public enum DataGraphPipelineSessionBindPointARM : int
    {
        [Obsolete("Deprecated in favour of \"TransientArm\"")]
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TRANSIENT_ARM")]
        DataGraphPipelineSessionBindPointTransientArm = 0,
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TRANSIENT_ARM")]
        TransientArm = 0,
    }
}
