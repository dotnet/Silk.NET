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
    PlatformMir = 0,

    [NativeName("VK_ICD_WSI_PLATFORM_WAYLAND")]
    [SupportedApiProfile("vulkan")]
    PlatformWayland = 1,

    [NativeName("VK_ICD_WSI_PLATFORM_WIN32")]
    [SupportedApiProfile("vulkan")]
    PlatformWin32 = 2,

    [NativeName("VK_ICD_WSI_PLATFORM_XCB")]
    [SupportedApiProfile("vulkan")]
    PlatformXcb = 3,

    [NativeName("VK_ICD_WSI_PLATFORM_XLIB")]
    [SupportedApiProfile("vulkan")]
    PlatformXlib = 4,

    [NativeName("VK_ICD_WSI_PLATFORM_ANDROID")]
    [SupportedApiProfile("vulkan")]
    PlatformANDROID = 5,

    [NativeName("VK_ICD_WSI_PLATFORM_MACOS")]
    [SupportedApiProfile("vulkan")]
    PlatformMacos = 6,

    [NativeName("VK_ICD_WSI_PLATFORM_IOS")]
    [SupportedApiProfile("vulkan")]
    PlatformIos = 7,

    [NativeName("VK_ICD_WSI_PLATFORM_DISPLAY")]
    [SupportedApiProfile("vulkan")]
    PlatformDisplay = 8,

    [NativeName("VK_ICD_WSI_PLATFORM_HEADLESS")]
    [SupportedApiProfile("vulkan")]
    PlatformHeadless = 9,

    [NativeName("VK_ICD_WSI_PLATFORM_METAL")]
    [SupportedApiProfile("vulkan")]
    PlatformMetal = 10,

    [NativeName("VK_ICD_WSI_PLATFORM_DIRECTFB")]
    [SupportedApiProfile("vulkan")]
    PlatformDirectFB = 11,

    [NativeName("VK_ICD_WSI_PLATFORM_VI")]
    [SupportedApiProfile("vulkan")]
    PlatformVi = 12,

    [NativeName("VK_ICD_WSI_PLATFORM_GGP")]
    [SupportedApiProfile("vulkan")]
    PlatformGGP = 13,

    [NativeName("VK_ICD_WSI_PLATFORM_SCREEN")]
    [SupportedApiProfile("vulkan")]
    PlatformScreen = 14,

    [NativeName("VK_ICD_WSI_PLATFORM_FUCHSIA")]
    [SupportedApiProfile("vulkan")]
    PlatformFUCHSIA = 15,
}
