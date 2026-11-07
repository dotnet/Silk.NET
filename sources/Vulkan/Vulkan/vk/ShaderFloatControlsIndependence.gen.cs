// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderFloatControlsIndependence")]
public enum ShaderFloatControlsIndependence : uint
{
    [NativeName("VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY")]
    Independence32BitOnly = 0,

    [NativeName("VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL")]
    IndependenceAll = 1,

    [NativeName("VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE")]
    IndependenceNone = 2,

    [NativeName("VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY_KHR")]
    Independence32BitOnlyKHR = Independence32BitOnly,

    [NativeName("VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL_KHR")]
    IndependenceAllKHR = IndependenceAll,

    [NativeName("VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE_KHR")]
    IndependenceNoneKHR = IndependenceNone,
}
