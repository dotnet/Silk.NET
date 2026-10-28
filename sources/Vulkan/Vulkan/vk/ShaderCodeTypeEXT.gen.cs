// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderCodeTypeEXT")]
public enum ShaderCodeTypeEXT : uint
{
    [NativeName("VK_SHADER_CODE_TYPE_BINARY_EXT")]
    Binary = 0,

    [NativeName("VK_SHADER_CODE_TYPE_SPIRV_EXT")]
    Spirv = 1,
}
