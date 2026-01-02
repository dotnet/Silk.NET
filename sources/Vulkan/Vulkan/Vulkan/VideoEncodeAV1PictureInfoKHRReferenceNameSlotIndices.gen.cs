// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(7)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_video_encode_av1"],
    ImpliesSets = ["VK_KHR_video_encode_queue"]
)]
public partial struct VideoEncodeAV1PictureInfoKHRReferenceNameSlotIndices
{
    [SupportedApiProfile("vulkan")]
    public int E0;
}
