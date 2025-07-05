// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum ShaderInfoTypeAMD : uint
{
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    StatisticsAMD = 0,

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    BinaryAMD = 1,

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    DisassemblyAMD = 2,

    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    MaxEnumAMD = 0x7FFFFFFF,
}
