// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIcdWsiPlatform")]
[SupportedApiProfile("vulkan")]
public enum IcdWsiPlatform : uint
{
    [NativeName("VK_ICD_WSI_PLATFORM_MIR")]
    [SupportedApiProfile("vulkan")]
    Mir = 0,

    [NativeName("VK_ICD_WSI_PLATFORM_WAYLAND")]
    [SupportedApiProfile("vulkan")]
    Wayland = 1,

    [NativeName("VK_ICD_WSI_PLATFORM_WIN32")]
    [SupportedApiProfile("vulkan")]
    Win32 = 2,

    [NativeName("VK_ICD_WSI_PLATFORM_XCB")]
    [SupportedApiProfile("vulkan")]
    Xcb = 3,

    [NativeName("VK_ICD_WSI_PLATFORM_XLIB")]
    [SupportedApiProfile("vulkan")]
    Xlib = 4,

    [NativeName("VK_ICD_WSI_PLATFORM_ANDROID")]
    [SupportedApiProfile("vulkan")]
    Android = 5,

    [NativeName("VK_ICD_WSI_PLATFORM_MACOS")]
    [SupportedApiProfile("vulkan")]
    Macos = 6,

    [NativeName("VK_ICD_WSI_PLATFORM_IOS")]
    [SupportedApiProfile("vulkan")]
    Ios = 7,

    [NativeName("VK_ICD_WSI_PLATFORM_DISPLAY")]
    [SupportedApiProfile("vulkan")]
    Display = 8,

    [NativeName("VK_ICD_WSI_PLATFORM_HEADLESS")]
    [SupportedApiProfile("vulkan")]
    Headless = 9,

    [NativeName("VK_ICD_WSI_PLATFORM_METAL")]
    [SupportedApiProfile("vulkan")]
    Metal = 10,

    [NativeName("VK_ICD_WSI_PLATFORM_DIRECTFB")]
    [SupportedApiProfile("vulkan")]
    Directfb = 11,

    [NativeName("VK_ICD_WSI_PLATFORM_VI")]
    [SupportedApiProfile("vulkan")]
    Vi = 12,

    [NativeName("VK_ICD_WSI_PLATFORM_GGP")]
    [SupportedApiProfile("vulkan")]
    Ggp = 13,

    [NativeName("VK_ICD_WSI_PLATFORM_SCREEN")]
    [SupportedApiProfile("vulkan")]
    Screen = 14,

    [NativeName("VK_ICD_WSI_PLATFORM_FUCHSIA")]
    [SupportedApiProfile("vulkan")]
    Fuchsia = 15,
}
