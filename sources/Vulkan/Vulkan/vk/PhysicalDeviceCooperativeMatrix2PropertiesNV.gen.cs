// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceCooperativeMatrix2PropertiesNV")]
public unsafe partial struct PhysicalDeviceCooperativeMatrix2PropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceCooperativeMatrix2PropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("cooperativeMatrixWorkgroupScopeMaxWorkgroupSize")]
    public uint CooperativeMatrixWorkgroupScopeMaxWorkgroupSize;

    [NativeName("cooperativeMatrixFlexibleDimensionsMaxDimension")]
    public uint CooperativeMatrixFlexibleDimensionsMaxDimension;

    [NativeName("cooperativeMatrixWorkgroupScopeReservedSharedMemory")]
    public uint CooperativeMatrixWorkgroupScopeReservedSharedMemory;

    public PhysicalDeviceCooperativeMatrix2PropertiesNV() { }
}
