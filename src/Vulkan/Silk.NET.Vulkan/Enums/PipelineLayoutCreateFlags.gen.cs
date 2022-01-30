// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineLayoutCreateFlags")]
    public enum PipelineLayoutCreateFlags : int
    {
        [NativeName("Name", "VK_PIPELINE_LAYOUT_CREATE_RESERVED_0_BIT_AMD")]
        PipelineLayoutCreateReserved0BitAmd = 1,
        [NativeName("Name", "VK_PIPELINE_LAYOUT_CREATE_RESERVED_1_BIT_AMD")]
        PipelineLayoutCreateReserved1BitAmd = 2,
    }
}
