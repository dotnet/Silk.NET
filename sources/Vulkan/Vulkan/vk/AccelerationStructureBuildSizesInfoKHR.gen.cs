// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureBuildSizesInfoKHR")]
public unsafe partial struct AccelerationStructureBuildSizesInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AccelerationStructureBuildSizesInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("accelerationStructureSize")]
    public ulong AccelerationStructureSize;

    [NativeName("updateScratchSize")]
    public ulong UpdateScratchSize;

    [NativeName("buildScratchSize")]
    public ulong BuildScratchSize;

    public AccelerationStructureBuildSizesInfoKHR() { }
}
