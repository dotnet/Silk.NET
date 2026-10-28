// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectExecutionSetInfoTypeEXT")]
public enum IndirectExecutionSetInfoTypeEXT : uint
{
    [NativeName("VK_INDIRECT_EXECUTION_SET_INFO_TYPE_PIPELINES_EXT")]
    Pipelines = 0,

    [NativeName("VK_INDIRECT_EXECUTION_SET_INFO_TYPE_SHADER_OBJECTS_EXT")]
    ShaderObjects = 1,
}
