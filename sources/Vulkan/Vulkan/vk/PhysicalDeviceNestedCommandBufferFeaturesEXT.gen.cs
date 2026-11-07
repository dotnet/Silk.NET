// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceNestedCommandBufferFeaturesEXT")]
public unsafe partial struct PhysicalDeviceNestedCommandBufferFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceNestedCommandBufferFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("nestedCommandBuffer")]
    public MaybeBool<uint> NestedCommandBuffer;

    [NativeName("nestedCommandBufferRendering")]
    public MaybeBool<uint> NestedCommandBufferRendering;

    [NativeName("nestedCommandBufferSimultaneousUse")]
    public MaybeBool<uint> NestedCommandBufferSimultaneousUse;

    public PhysicalDeviceNestedCommandBufferFeaturesEXT() { }
}
