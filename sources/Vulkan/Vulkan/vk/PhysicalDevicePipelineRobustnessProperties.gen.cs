// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevicePipelineRobustnessProperties")]
public unsafe partial struct PhysicalDevicePipelineRobustnessProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDevicePipelineRobustnessProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("defaultRobustnessStorageBuffers")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers;

    [NativeName("defaultRobustnessUniformBuffers")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers;

    [NativeName("defaultRobustnessVertexInputs")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs;

    [NativeName("defaultRobustnessImages")]
    public PipelineRobustnessImageBehavior DefaultRobustnessImages;

    public PhysicalDevicePipelineRobustnessProperties() { }
}
