// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueFamilyDataGraphPropertiesARM")]
public unsafe partial struct QueueFamilyDataGraphPropertiesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.QueueFamilyDataGraphPropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("engine")]
    public PhysicalDeviceDataGraphProcessingEngineARM Engine;

    [NativeName("operation")]
    public PhysicalDeviceDataGraphOperationSupportARM Operation;

    public QueueFamilyDataGraphPropertiesARM() { }
}
