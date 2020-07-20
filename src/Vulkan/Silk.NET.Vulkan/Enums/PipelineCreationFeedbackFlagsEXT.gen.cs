// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkPipelineCreationFeedbackFlagsEXT")]
    public enum PipelineCreationFeedbackFlagsEXT
    {
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT")]
        PipelineCreationFeedbackValidBitExt = 1,
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT")]
        PipelineCreationFeedbackApplicationPipelineCacheHitBitExt = 2,
        [NativeName("Name", "VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT")]
        PipelineCreationFeedbackBasePipelineAccelerationBitExt = 4,
    }
}
