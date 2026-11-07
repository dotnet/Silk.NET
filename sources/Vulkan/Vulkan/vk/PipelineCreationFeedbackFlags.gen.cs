// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineCreationFeedbackFlags")]
[Flags]
public enum PipelineCreationFeedbackFlags : uint
{
    None = 0x0,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT")]
    ValidBit = 0x1,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT")]
    ApplicationPipelineCacheHitBit = 0x2,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT")]
    BasePipelineAccelerationBit = 0x4,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT")]
    ValidBitEXT = ValidBit,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT")]
    ApplicationPipelineCacheHitBitEXT = ApplicationPipelineCacheHitBit,

    [NativeName("VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT")]
    BasePipelineAccelerationBitEXT = BasePipelineAccelerationBit,
}
