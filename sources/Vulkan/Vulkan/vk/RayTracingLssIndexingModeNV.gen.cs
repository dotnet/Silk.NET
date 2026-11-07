// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRayTracingLssIndexingModeNV")]
public enum RayTracingLssIndexingModeNV : uint
{
    [NativeName("VK_RAY_TRACING_LSS_INDEXING_MODE_LIST_NV")]
    List = 0,

    [NativeName("VK_RAY_TRACING_LSS_INDEXING_MODE_SUCCESSIVE_NV")]
    Successive = 1,
}
