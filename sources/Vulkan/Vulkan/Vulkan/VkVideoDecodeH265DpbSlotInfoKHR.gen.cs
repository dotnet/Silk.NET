// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkVideoDecodeH265DpbSlotInfoKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public void* pNext;

    [NativeTypeName("const StdVideoDecodeH265ReferenceInfo *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    public StdVideoDecodeH265ReferenceInfo* pStdReferenceInfo;
}
