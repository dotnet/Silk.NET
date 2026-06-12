// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVideoEncodeFeedback2FeaturesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceVideoEncodeFeedback2FeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public StructureType SType = StructureType.PhysicalDeviceVideoEncodeFeedback2FeaturesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public void* PNext;

    [NativeName("videoEncodeFeedback2")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public MaybeBool<uint> VideoEncodeFeedback2;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_feedback2"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public PhysicalDeviceVideoEncodeFeedback2FeaturesKHR() { }
}
