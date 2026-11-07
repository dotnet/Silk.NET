// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMaintenance5Features")]
public unsafe partial struct PhysicalDeviceMaintenance5Features
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMaintenance5Features;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maintenance5")]
    public MaybeBool<uint> Maintenance5;

    public PhysicalDeviceMaintenance5Features() { }
}
