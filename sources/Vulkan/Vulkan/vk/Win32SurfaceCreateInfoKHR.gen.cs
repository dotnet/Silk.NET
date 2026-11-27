// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkWin32SurfaceCreateInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct Win32SurfaceCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public StructureType SType = StructureType.Win32SurfaceCreateInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public uint Flags;

    [NativeName("hinstance")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* Hinstance;

    [NativeName("hwnd")]
    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* Hwnd;

    [SupportedApiProfile("vulkan", ["VK_KHR_win32_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public Win32SurfaceCreateInfoKHR() { }
}
