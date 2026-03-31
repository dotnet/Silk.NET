// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimeGOOGLE")]
[NameAffix("Suffix", "KhronosVendor", "GOOGLE")]
[SupportedApiProfile("vulkan")]
public partial struct VkPresentTimeGOOGLE
{
    [NativeName("presentID")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public uint PresentID;

    [NativeName("desiredPresentTime")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public ulong DesiredPresentTime;
}
