// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkVideoCapabilityFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VideoCapabilityFlagsKHR : uint
{
    None = 0x0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    ProtectedContentBitKHR = 0x1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    SeparateReferenceImagesBitKHR = 0x2,
}
