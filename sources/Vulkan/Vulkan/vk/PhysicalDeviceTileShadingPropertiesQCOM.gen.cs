// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTileShadingPropertiesQCOM")]
public unsafe partial struct PhysicalDeviceTileShadingPropertiesQCOM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceTileShadingPropertiesQCOM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxApronSize")]
    public uint MaxApronSize;

    [NativeName("preferNonCoherent")]
    public MaybeBool<uint> PreferNonCoherent;

    [NativeName("tileGranularity")]
    public Extent2D TileGranularity;

    [NativeName("maxTileShadingRate")]
    public Extent2D MaxTileShadingRate;

    public PhysicalDeviceTileShadingPropertiesQCOM() { }
}
