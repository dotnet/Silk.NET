// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceExtendedDynamicState2FeaturesEXT")]
public unsafe partial struct PhysicalDeviceExtendedDynamicState2FeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceExtendedDynamicState2FeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("extendedDynamicState2")]
    public MaybeBool<uint> ExtendedDynamicState2;

    [NativeName("extendedDynamicState2LogicOp")]
    public MaybeBool<uint> ExtendedDynamicState2LogicOp;

    [NativeName("extendedDynamicState2PatchControlPoints")]
    public MaybeBool<uint> ExtendedDynamicState2PatchControlPoints;

    public PhysicalDeviceExtendedDynamicState2FeaturesEXT() { }
}
