// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRayTracingPipelinePropertiesKHR")]
public unsafe partial struct PhysicalDeviceRayTracingPipelinePropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceRayTracingPipelinePropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderGroupHandleSize")]
    public uint ShaderGroupHandleSize;

    [NativeName("maxRayRecursionDepth")]
    public uint MaxRayRecursionDepth;

    [NativeName("maxShaderGroupStride")]
    public uint MaxShaderGroupStride;

    [NativeName("shaderGroupBaseAlignment")]
    public uint ShaderGroupBaseAlignment;

    [NativeName("shaderGroupHandleCaptureReplaySize")]
    public uint ShaderGroupHandleCaptureReplaySize;

    [NativeName("maxRayDispatchInvocationCount")]
    public uint MaxRayDispatchInvocationCount;

    [NativeName("shaderGroupHandleAlignment")]
    public uint ShaderGroupHandleAlignment;

    [NativeName("maxRayHitAttributeSize")]
    public uint MaxRayHitAttributeSize;

    public PhysicalDeviceRayTracingPipelinePropertiesKHR() { }
}
