// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceOpacityMicromapPropertiesKHR")]
public unsafe partial struct PhysicalDeviceOpacityMicromapPropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceOpacityMicromapPropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxOpacity2StateSubdivisionLevel")]
    public uint MaxOpacity2StateSubdivisionLevel;

    [NativeName("maxOpacity4StateSubdivisionLevel")]
    public uint MaxOpacity4StateSubdivisionLevel;

    [NativeName("maxOpacityLossy4StateSubdivisionLevel")]
    public uint MaxOpacityLossy4StateSubdivisionLevel;

    [NativeName("maxMicromapTriangles")]
    public ulong MaxMicromapTriangles;

    public PhysicalDeviceOpacityMicromapPropertiesKHR() { }
}
