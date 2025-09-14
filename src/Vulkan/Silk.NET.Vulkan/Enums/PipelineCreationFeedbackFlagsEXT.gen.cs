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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ValidBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT")]
        PipelineCreationFeedbackValidBit = 1,
        [Obsolete("Deprecated in favour of \"ApplicationPipelineCacheHitBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT")]
        PipelineCreationFeedbackApplicationPipelineCacheHitBit = 2,
        [Obsolete("Deprecated in favour of \"BasePipelineAccelerationBit\"")]
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT")]
        PipelineCreationFeedbackBasePipelineAccelerationBit = 4,
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT")]
        ValidBit = 1,
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT")]
        ApplicationPipelineCacheHitBit = 2,
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT")]
        BasePipelineAccelerationBit = 4,
    }
}
