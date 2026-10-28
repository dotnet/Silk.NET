// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRobustness2FeaturesKHR")]
public unsafe partial struct PhysicalDeviceRobustness2FeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceRobustness2FeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("robustBufferAccess2")]
    public MaybeBool<uint> RobustBufferAccess2;

    [NativeName("robustImageAccess2")]
    public MaybeBool<uint> RobustImageAccess2;

    [NativeName("nullDescriptor")]
    public MaybeBool<uint> NullDescriptor;

    public PhysicalDeviceRobustness2FeaturesKHR() { }
}
