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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"IndependentSetsBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT")]
        PipelineLayoutCreateIndependentSetsBitExt = 2,
        [NativeName("Name", "VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT")]
        IndependentSetsBitExt = 2,
    }
}
