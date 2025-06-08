// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPerformanceValueDataINTEL
{
    [FieldOffset(0)]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public uint value32;

    [FieldOffset(0)]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public ulong value64;

    [FieldOffset(0)]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public float valueFloat;

    [FieldOffset(0)]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public uint valueBool;

    [FieldOffset(0)]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public sbyte* valueString;
}
