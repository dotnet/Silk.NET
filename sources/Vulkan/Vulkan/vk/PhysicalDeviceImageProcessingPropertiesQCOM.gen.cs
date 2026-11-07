// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceImageProcessingPropertiesQCOM")]
public unsafe partial struct PhysicalDeviceImageProcessingPropertiesQCOM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceImageProcessingPropertiesQCOM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxWeightFilterPhases")]
    public uint MaxWeightFilterPhases;

    [NativeName("maxWeightFilterDimension")]
    public Extent2D MaxWeightFilterDimension;

    [NativeName("maxBlockMatchRegion")]
    public Extent2D MaxBlockMatchRegion;

    [NativeName("maxBoxFilterBlockSize")]
    public Extent2D MaxBoxFilterBlockSize;

    public PhysicalDeviceImageProcessingPropertiesQCOM() { }
}
