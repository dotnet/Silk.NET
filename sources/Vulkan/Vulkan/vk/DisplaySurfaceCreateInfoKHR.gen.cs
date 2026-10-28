// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplaySurfaceCreateInfoKHR")]
public unsafe partial struct DisplaySurfaceCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DisplaySurfaceCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("displayMode")]
    public DisplayModeHandleKHR DisplayMode;

    [NativeName("planeIndex")]
    public uint PlaneIndex;

    [NativeName("planeStackIndex")]
    public uint PlaneStackIndex;

    [NativeName("transform")]
    public SurfaceTransformFlagsKHR Transform;

    [NativeName("globalAlpha")]
    public float GlobalAlpha;

    [NativeName("alphaMode")]
    public DisplayPlaneAlphaFlagsKHR AlphaMode;

    [NativeName("imageExtent")]
    public Extent2D ImageExtent;

    public DisplaySurfaceCreateInfoKHR() { }
}
