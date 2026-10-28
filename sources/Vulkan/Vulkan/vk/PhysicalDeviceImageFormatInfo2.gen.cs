// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImageFormatInfo2")]
public unsafe partial struct PhysicalDeviceImageFormatInfo2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceImageFormatInfo2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("format")]
    public Format Format;

    [NativeName("type")]
    public ImageType Type;

    [NativeName("tiling")]
    public ImageTiling Tiling;

    [NativeName("usage")]
    public ImageUsageFlags Usage;

    [NativeName("flags")]
    public ImageCreateFlags Flags;

    public PhysicalDeviceImageFormatInfo2() { }
}
