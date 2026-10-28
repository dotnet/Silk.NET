// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMapMemoryPlacedFeaturesEXT")]
public unsafe partial struct PhysicalDeviceMapMemoryPlacedFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMapMemoryPlacedFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("memoryMapPlaced")]
    public MaybeBool<uint> MemoryMapPlaced;

    [NativeName("memoryMapRangePlaced")]
    public MaybeBool<uint> MemoryMapRangePlaced;

    [NativeName("memoryUnmapReserve")]
    public MaybeBool<uint> MemoryUnmapReserve;

    public PhysicalDeviceMapMemoryPlacedFeaturesEXT() { }
}
