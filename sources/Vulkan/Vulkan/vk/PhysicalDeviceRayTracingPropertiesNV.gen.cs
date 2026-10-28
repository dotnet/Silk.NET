// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRayTracingPropertiesNV")]
public unsafe partial struct PhysicalDeviceRayTracingPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceRayTracingPropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderGroupHandleSize")]
    public uint ShaderGroupHandleSize;

    [NativeName("maxRecursionDepth")]
    public uint MaxRecursionDepth;

    [NativeName("maxShaderGroupStride")]
    public uint MaxShaderGroupStride;

    [NativeName("shaderGroupBaseAlignment")]
    public uint ShaderGroupBaseAlignment;

    [NativeName("maxGeometryCount")]
    public ulong MaxGeometryCount;

    [NativeName("maxInstanceCount")]
    public ulong MaxInstanceCount;

    [NativeName("maxTriangleCount")]
    public ulong MaxTriangleCount;

    [NativeName("maxDescriptorSetAccelerationStructures")]
    public uint MaxDescriptorSetAccelerationStructures;

    public PhysicalDeviceRayTracingPropertiesNV() { }
}
