// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIcdSurfaceDisplay")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct IcdSurfaceDisplay
{
    [NativeName("@base")]
    [SupportedApiProfile("vulkan")]
    public IcdSurfaceBase @base;

    [NativeName("displayMode")]
    [SupportedApiProfile("vulkan")]
    public DisplayModeHandleKHR DisplayMode;

    [NativeName("planeIndex")]
    [SupportedApiProfile("vulkan")]
    public uint PlaneIndex;

    [NativeName("planeStackIndex")]
    [SupportedApiProfile("vulkan")]
    public uint PlaneStackIndex;

    [NativeName("transform")]
    [SupportedApiProfile("vulkan")]
    public SurfaceTransformFlagsKHR Transform;

    [NativeName("globalAlpha")]
    [SupportedApiProfile("vulkan")]
    public float GlobalAlpha;

    [NativeName("alphaMode")]
    [SupportedApiProfile("vulkan")]
    public DisplayPlaneAlphaFlagsKHR AlphaMode;

    [NativeName("imageExtent")]
    [SupportedApiProfile("vulkan")]
    public Extent2D ImageExtent;
}
