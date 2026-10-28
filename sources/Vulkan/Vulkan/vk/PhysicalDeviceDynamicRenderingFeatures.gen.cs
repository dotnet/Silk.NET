// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDynamicRenderingFeatures")]
public unsafe partial struct PhysicalDeviceDynamicRenderingFeatures
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDynamicRenderingFeatures;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("dynamicRendering")]
    public MaybeBool<uint> DynamicRendering;

    public PhysicalDeviceDynamicRenderingFeatures() { }
}
