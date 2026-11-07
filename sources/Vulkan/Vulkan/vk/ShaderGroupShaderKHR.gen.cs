// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderGroupShaderKHR")]
public enum ShaderGroupShaderKHR : uint
{
    [NativeName("VK_SHADER_GROUP_SHADER_GENERAL_KHR")]
    General = 0,

    [NativeName("VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR")]
    ClosestHit = 1,

    [NativeName("VK_SHADER_GROUP_SHADER_ANY_HIT_KHR")]
    AnyHit = 2,

    [NativeName("VK_SHADER_GROUP_SHADER_INTERSECTION_KHR")]
    Intersection = 3,
}
