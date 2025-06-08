// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(7)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_video_encode_av1"],
    ImpliesSets = ["VK_KHR_video_encode_queue"]
)]
public partial struct VkVideoEncodeAV1PictureInfoKHR_referenceNameSlotIndices
{
    [SupportedApiProfile("vulkan")]
    public int e0;
}
