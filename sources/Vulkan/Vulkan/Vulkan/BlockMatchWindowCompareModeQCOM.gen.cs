// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "QCOM", 0)]
[NativeName("VkBlockMatchWindowCompareModeQCOM")]
[SupportedApiProfile("vulkan")]
public enum BlockMatchWindowCompareModeQCOM : uint
{
    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    Minqcom = 0,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_image_processing2"],
        ImpliesSets = ["VK_QCOM_image_processing"]
    )]
    Maxqcom = 1,
}
