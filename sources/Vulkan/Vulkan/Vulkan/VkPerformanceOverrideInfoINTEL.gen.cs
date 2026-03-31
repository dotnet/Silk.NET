// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceOverrideInfoINTEL")]
[NameAffix("Suffix", "KhronosVendor", "INTEL")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPerformanceOverrideInfoINTEL
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public void* PNext;

    [NativeName("type")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public VkPerformanceOverrideTypeINTEL Type;

    [NativeName("enable")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public uint Enable;

    [NativeName("parameter")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public ulong Parameter;
}
