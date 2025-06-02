// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum AntiLagStageAMD
{
    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    InputAMD = 0,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    PresentAMD = 1,

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    MaxEnumAMD = 0x7FFFFFFF,
}
