// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PerformanceMarkerInfoIntel
{
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public void* PNext;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    public ulong Marker;
}
