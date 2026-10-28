// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFragmentDensityMap2PropertiesEXT")]
public unsafe partial struct PhysicalDeviceFragmentDensityMap2PropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceFragmentDensityMap2PropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("subsampledLoads")]
    public MaybeBool<uint> SubsampledLoads;

    [NativeName("subsampledCoarseReconstructionEarlyAccess")]
    public MaybeBool<uint> SubsampledCoarseReconstructionEarlyAccess;

    [NativeName("maxSubsampledArrayLayers")]
    public uint MaxSubsampledArrayLayers;

    [NativeName("maxDescriptorSetSubsampledSamplers")]
    public uint MaxDescriptorSetSubsampledSamplers;

    public PhysicalDeviceFragmentDensityMap2PropertiesEXT() { }
}
