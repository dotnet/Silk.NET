// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceStreamMarkerInfoINTEL")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PerformanceStreamMarkerInfoIntel
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public void* PNext;

    [NativeName("marker")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public uint Marker;
}
