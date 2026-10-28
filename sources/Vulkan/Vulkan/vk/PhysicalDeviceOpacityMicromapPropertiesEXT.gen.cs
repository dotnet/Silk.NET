// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceOpacityMicromapPropertiesEXT")]
public unsafe partial struct PhysicalDeviceOpacityMicromapPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceOpacityMicromapPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxOpacity2StateSubdivisionLevel")]
    public uint MaxOpacity2StateSubdivisionLevel;

    [NativeName("maxOpacity4StateSubdivisionLevel")]
    public uint MaxOpacity4StateSubdivisionLevel;

    public PhysicalDeviceOpacityMicromapPropertiesEXT() { }
}
