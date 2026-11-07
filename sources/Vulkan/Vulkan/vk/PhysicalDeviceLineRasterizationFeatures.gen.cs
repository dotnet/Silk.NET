// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceLineRasterizationFeatures")]
public unsafe partial struct PhysicalDeviceLineRasterizationFeatures
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceLineRasterizationFeatures;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("rectangularLines")]
    public MaybeBool<uint> RectangularLines;

    [NativeName("bresenhamLines")]
    public MaybeBool<uint> BresenhamLines;

    [NativeName("smoothLines")]
    public MaybeBool<uint> SmoothLines;

    [NativeName("stippledRectangularLines")]
    public MaybeBool<uint> StippledRectangularLines;

    [NativeName("stippledBresenhamLines")]
    public MaybeBool<uint> StippledBresenhamLines;

    [NativeName("stippledSmoothLines")]
    public MaybeBool<uint> StippledSmoothLines;

    public PhysicalDeviceLineRasterizationFeatures() { }
}
