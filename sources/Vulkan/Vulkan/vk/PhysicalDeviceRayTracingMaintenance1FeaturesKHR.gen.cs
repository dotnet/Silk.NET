// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR")]
public unsafe partial struct PhysicalDeviceRayTracingMaintenance1FeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceRayTracingMaintenance1FeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("rayTracingMaintenance1")]
    public MaybeBool<uint> RayTracingMaintenance1;

    [NativeName("rayTracingPipelineTraceRaysIndirect2")]
    public MaybeBool<uint> RayTracingPipelineTraceRaysIndirect2;

    public PhysicalDeviceRayTracingMaintenance1FeaturesKHR() { }
}
