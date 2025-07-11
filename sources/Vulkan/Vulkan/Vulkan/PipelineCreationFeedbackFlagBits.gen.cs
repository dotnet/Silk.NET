// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum PipelineCreationFeedbackFlags : uint
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    ValidBit = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    ApplicationPipelineCacheHitBit = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    BasePipelineAccelerationBit = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    ValidBitEXT = ValidBit,

    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    ApplicationPipelineCacheHitBitEXT = ApplicationPipelineCacheHitBit,

    [SupportedApiProfile("vulkan", ["VK_EXT_pipeline_creation_feedback"])]
    BasePipelineAccelerationBitEXT = BasePipelineAccelerationBit,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    FlagBitsMaxEnum = 0x7FFFFFFF,
}
