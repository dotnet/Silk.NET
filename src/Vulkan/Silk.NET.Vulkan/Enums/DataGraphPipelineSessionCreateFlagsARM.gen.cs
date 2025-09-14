// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDataGraphPipelineSessionCreateFlagsARM")]
    public enum DataGraphPipelineSessionCreateFlagsARM : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ProtectedBitArm\"")]
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_SESSION_CREATE_PROTECTED_BIT_ARM")]
        DataGraphPipelineSessionCreateProtectedBitArm = 1,
        [NativeName("Name", "VK_DATA_GRAPH_PIPELINE_SESSION_CREATE_PROTECTED_BIT_ARM")]
        ProtectedBitArm = 1,
    }
}
