// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_referenceNameSlotIndices_e__FixedBuffer")]
[InlineArray(3)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_video_decode_vp9"],
    ImpliesSets = ["VK_KHR_video_decode_queue"]
)]
public partial struct VideoDecodeVP9PictureInfoKHRReferenceNameSlotIndices
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public int E0;
}
