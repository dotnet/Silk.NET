// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainCreateInfoFoveationFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SwapchainCreateInfoFoveationFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SwapchainCreateInfoFoveationFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("flags")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    public SwapchainCreateFoveationFlagsFB Flags;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    public SwapchainCreateInfoFoveationFB() { }
}
