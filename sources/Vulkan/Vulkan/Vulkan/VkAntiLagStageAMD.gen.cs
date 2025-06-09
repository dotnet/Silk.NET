// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkAntiLagStageAMD : uint
{
    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_ANTI_LAG_STAGE_INPUT_AMD = 0,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_ANTI_LAG_STAGE_PRESENT_AMD = 1,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    VK_ANTI_LAG_STAGE_MAX_ENUM_AMD = 0x7FFFFFFF,
}
