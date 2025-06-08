// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoEncodeRateControlLayerInfoKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    public void* pNext;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    public ulong averageBitrate;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    public ulong maxBitrate;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    public uint frameRateNumerator;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    public uint frameRateDenominator;
}
