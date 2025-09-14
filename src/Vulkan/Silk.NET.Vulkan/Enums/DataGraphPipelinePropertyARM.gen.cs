// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDataGraphPipelinePropertyARM")]
    public enum DataGraphPipelinePropertyARM : int
    {
        [Obsolete("Deprecated in favour of \"CreationLogArm\"")]
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_PROPERTY_CREATION_LOG_ARM")]
        DataGraphPipelinePropertyCreationLogArm = 0,
        [Obsolete("Deprecated in favour of \"IdentifierArm\"")]
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_PROPERTY_IDENTIFIER_ARM")]
        DataGraphPipelinePropertyIdentifierArm = 1,
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_PROPERTY_CREATION_LOG_ARM")]
        CreationLogArm = 0,
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_PROPERTY_IDENTIFIER_ARM")]
        IdentifierArm = 1,
    }
}
