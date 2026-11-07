// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSurfaceCapabilitiesKHR")]
public partial struct SurfaceCapabilitiesKHR
{
    [NativeName("minImageCount")]
    public uint MinImageCount;

    [NativeName("maxImageCount")]
    public uint MaxImageCount;

    [NativeName("currentExtent")]
    public Extent2D CurrentExtent;

    [NativeName("minImageExtent")]
    public Extent2D MinImageExtent;

    [NativeName("maxImageExtent")]
    public Extent2D MaxImageExtent;

    [NativeName("maxImageArrayLayers")]
    public uint MaxImageArrayLayers;

    [NativeName("supportedTransforms")]
    public SurfaceTransformFlagsKHR SupportedTransforms;

    [NativeName("currentTransform")]
    public SurfaceTransformFlagsKHR CurrentTransform;

    [NativeName("supportedCompositeAlpha")]
    public CompositeAlphaFlagsKHR SupportedCompositeAlpha;

    [NativeName("supportedUsageFlags")]
    public ImageUsageFlags SupportedUsageFlags;
}
