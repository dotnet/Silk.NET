// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceAccelerationStructureFeaturesKHR")]
public unsafe partial struct PhysicalDeviceAccelerationStructureFeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("accelerationStructure")]
    public MaybeBool<uint> AccelerationStructure;

    [NativeName("accelerationStructureCaptureReplay")]
    public MaybeBool<uint> AccelerationStructureCaptureReplay;

    [NativeName("accelerationStructureIndirectBuild")]
    public MaybeBool<uint> AccelerationStructureIndirectBuild;

    [NativeName("accelerationStructureHostCommands")]
    public MaybeBool<uint> AccelerationStructureHostCommands;

    [NativeName("descriptorBindingAccelerationStructureUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingAccelerationStructureUpdateAfterBind;

    public PhysicalDeviceAccelerationStructureFeaturesKHR() { }
}
