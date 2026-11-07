// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV")]
public unsafe partial struct PhysicalDeviceFragmentShadingRateEnumsFeaturesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceFragmentShadingRateEnumsFeaturesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("fragmentShadingRateEnums")]
    public MaybeBool<uint> FragmentShadingRateEnums;

    [NativeName("supersampleFragmentShadingRates")]
    public MaybeBool<uint> SupersampleFragmentShadingRates;

    [NativeName("noInvocationFragmentShadingRates")]
    public MaybeBool<uint> NoInvocationFragmentShadingRates;

    public PhysicalDeviceFragmentShadingRateEnumsFeaturesNV() { }
}
