// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRayTracingShaderGroupTypeKHR")]
public enum RayTracingShaderGroupTypeKHR : uint
{
    [NativeName("VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR")]
    General = 0,

    [NativeName("VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR")]
    TrianglesHitGroup = 1,

    [NativeName("VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR")]
    ProceduralHitGroup = 2,

    [NativeName("VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV")]
    GeneralNV = General,

    [NativeName("VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV")]
    TrianglesHitGroupNV = TrianglesHitGroup,

    [NativeName("VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV")]
    ProceduralHitGroupNV = ProceduralHitGroup,
}
