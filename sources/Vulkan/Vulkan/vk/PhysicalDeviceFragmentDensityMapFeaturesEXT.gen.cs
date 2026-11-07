// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFragmentDensityMapFeaturesEXT")]
public unsafe partial struct PhysicalDeviceFragmentDensityMapFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceFragmentDensityMapFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("fragmentDensityMap")]
    public MaybeBool<uint> FragmentDensityMap;

    [NativeName("fragmentDensityMapDynamic")]
    public MaybeBool<uint> FragmentDensityMapDynamic;

    [NativeName("fragmentDensityMapNonSubsampledImages")]
    public MaybeBool<uint> FragmentDensityMapNonSubsampledImages;

    public PhysicalDeviceFragmentDensityMapFeaturesEXT() { }
}
