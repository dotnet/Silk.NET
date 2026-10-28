// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTileMemoryHeapPropertiesQCOM")]
public unsafe partial struct PhysicalDeviceTileMemoryHeapPropertiesQCOM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceTileMemoryHeapPropertiesQCOM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("queueSubmitBoundary")]
    public MaybeBool<uint> QueueSubmitBoundary;

    [NativeName("tileBufferTransfers")]
    public MaybeBool<uint> TileBufferTransfers;

    public PhysicalDeviceTileMemoryHeapPropertiesQCOM() { }
}
