// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkXlibSurfaceCreateInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct XlibSurfaceCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public StructureType SType = StructureType.XlibSurfaceCreateInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public uint Flags;

    [NativeName("dpy")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public void* Dpy;

    [NativeName("window")]
    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public nuint Window;

    [SupportedApiProfile("vulkan", ["VK_KHR_xlib_surface"], ImpliesSets = ["VK_KHR_surface"])]
    public XlibSurfaceCreateInfoKHR() { }
}
