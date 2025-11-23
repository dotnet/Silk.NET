// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PerformanceOverrideInfoIntel
{
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public void* PNext;

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public PerformanceOverrideTypeIntel Type;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public uint Enable;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public ulong Parameter;
}
