// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoDecodeH265InlineSessionParametersInfoKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public void* pNext;

    [NativeTypeName("const StdVideoH265VideoParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH265VideoParameterSet* pStdVPS;

    [NativeTypeName("const StdVideoH265SequenceParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH265SequenceParameterSet* pStdSPS;

    [NativeTypeName("const StdVideoH265PictureParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265", "VK_KHR_video_maintenance2"],
        ImpliesSets = ["VK_KHR_video_queue"],
        RequireAll = true
    )]
    public StdVideoH265PictureParameterSet* pStdPPS;
}
