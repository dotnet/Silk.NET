// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAntiLagStageAMD")]
public enum AntiLagStageAMD : uint
{
    [NativeName("VK_ANTI_LAG_STAGE_INPUT_AMD")]
    Input = 0,

    [NativeName("VK_ANTI_LAG_STAGE_PRESENT_AMD")]
    Present = 1,
}
