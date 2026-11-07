// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMaintenance11FeaturesKHR")]
public unsafe partial struct PhysicalDeviceMaintenance11FeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMaintenance11FeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maintenance11")]
    public MaybeBool<uint> Maintenance11;

    public PhysicalDeviceMaintenance11FeaturesKHR() { }
}
