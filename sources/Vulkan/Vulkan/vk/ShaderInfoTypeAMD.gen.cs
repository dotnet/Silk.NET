// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderInfoTypeAMD")]
public enum ShaderInfoTypeAMD : uint
{
    [NativeName("VK_SHADER_INFO_TYPE_STATISTICS_AMD")]
    Statistics = 0,

    [NativeName("VK_SHADER_INFO_TYPE_BINARY_AMD")]
    Binary = 1,

    [NativeName("VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD")]
    Disassembly = 2,
}
