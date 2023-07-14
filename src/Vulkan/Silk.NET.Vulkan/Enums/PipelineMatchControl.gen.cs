// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineMatchControl")]
    public enum PipelineMatchControl : int
    {
        [NativeName("Name", "VK_PIPELINE_MATCH_CONTROL_APPLICATION_UUID_EXACT_MATCH")]
        ApplicationUuidExactMatch = 0,
    }
}
