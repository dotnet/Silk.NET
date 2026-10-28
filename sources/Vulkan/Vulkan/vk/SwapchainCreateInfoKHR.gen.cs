// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainCreateInfoKHR")]
public unsafe partial struct SwapchainCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SwapchainCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public SwapchainCreateFlagsKHR Flags;

    [NativeName("surface")]
    public SurfaceHandleKHR Surface;

    [NativeName("minImageCount")]
    public uint MinImageCount;

    [NativeName("imageFormat")]
    public Format ImageFormat;

    [NativeName("imageColorSpace")]
    public ColorSpaceKHR ImageColorSpace;

    [NativeName("imageExtent")]
    public Extent2D ImageExtent;

    [NativeName("imageArrayLayers")]
    public uint ImageArrayLayers;

    [NativeName("imageUsage")]
    public ImageUsageFlags ImageUsage;

    [NativeName("imageSharingMode")]
    public SharingMode ImageSharingMode;

    [NativeName("queueFamilyIndexCount")]
    public uint QueueFamilyIndexCount;

    [NativeName("pQueueFamilyIndices")]
    public uint* PQueueFamilyIndices;

    [NativeName("preTransform")]
    public SurfaceTransformFlagsKHR PreTransform;

    [NativeName("compositeAlpha")]
    public CompositeAlphaFlagsKHR CompositeAlpha;

    [NativeName("presentMode")]
    public PresentModeKHR PresentMode;

    [NativeName("clipped")]
    public MaybeBool<uint> Clipped;

    [NativeName("oldSwapchain")]
    public SwapchainHandleKHR OldSwapchain;

    public SwapchainCreateInfoKHR() { }
}
