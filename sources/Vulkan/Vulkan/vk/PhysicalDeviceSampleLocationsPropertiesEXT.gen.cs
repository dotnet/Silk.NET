// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSampleLocationsPropertiesEXT")]
public unsafe partial struct PhysicalDeviceSampleLocationsPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceSampleLocationsPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("sampleLocationSampleCounts")]
    public SampleCountFlags SampleLocationSampleCounts;

    [NativeName("maxSampleLocationGridSize")]
    public Extent2D MaxSampleLocationGridSize;

    [NativeName("sampleLocationCoordinateRange")]
    public PhysicalDeviceSampleLocationsPropertiesEXTSampleLocationCoordinateRange SampleLocationCoordinateRange;

    [NativeName("sampleLocationSubPixelBits")]
    public uint SampleLocationSubPixelBits;

    [NativeName("variableSampleLocations")]
    public MaybeBool<uint> VariableSampleLocations;

    public PhysicalDeviceSampleLocationsPropertiesEXT() { }
}
