// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineCreationFeedbackFlagsEXT")]
    public enum PipelineCreationFeedbackFlagsEXT : int
    {
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT")]
        PipelineCreationFeedbackValidBitExt = 1,
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT")]
        PipelineCreationFeedbackApplicationPipelineCacheHitBitExt = 2,
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT")]
        PipelineCreationFeedbackBasePipelineAccelerationBitExt = 4,
    }
}
