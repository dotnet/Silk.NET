// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRayTracingPipelineFeaturesKHR")]
public unsafe partial struct PhysicalDeviceRayTracingPipelineFeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceRayTracingPipelineFeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("rayTracingPipeline")]
    public MaybeBool<uint> RayTracingPipeline;

    [NativeName("rayTracingPipelineShaderGroupHandleCaptureReplay")]
    public MaybeBool<uint> RayTracingPipelineShaderGroupHandleCaptureReplay;

    [NativeName("rayTracingPipelineShaderGroupHandleCaptureReplayMixed")]
    public MaybeBool<uint> RayTracingPipelineShaderGroupHandleCaptureReplayMixed;

    [NativeName("rayTracingPipelineTraceRaysIndirect")]
    public MaybeBool<uint> RayTracingPipelineTraceRaysIndirect;

    [NativeName("rayTraversalPrimitiveCulling")]
    public MaybeBool<uint> RayTraversalPrimitiveCulling;

    public PhysicalDeviceRayTracingPipelineFeaturesKHR() { }
}
