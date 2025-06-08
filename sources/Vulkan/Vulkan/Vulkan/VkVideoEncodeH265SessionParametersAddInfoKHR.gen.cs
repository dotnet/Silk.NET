// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoEncodeH265SessionParametersAddInfoKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint stdVPSCount;

    [NativeTypeName("const StdVideoH265VideoParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public StdVideoH265VideoParameterSet* pStdVPSs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint stdSPSCount;

    [NativeTypeName("const StdVideoH265SequenceParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public StdVideoH265SequenceParameterSet* pStdSPSs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public uint stdPPSCount;

    [NativeTypeName("const StdVideoH265PictureParameterSet *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    public StdVideoH265PictureParameterSet* pStdPPSs;
}
