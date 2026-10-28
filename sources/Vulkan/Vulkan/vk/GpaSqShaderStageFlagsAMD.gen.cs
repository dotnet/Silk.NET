// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaSqShaderStageFlagsAMD")]
[Flags]
public enum GpaSqShaderStageFlagsAMD : uint
{
    None = 0x0,

    [NativeName("VK_GPA_SQ_SHADER_STAGE_PS_BIT_AMD")]
    PsBit = 0x1,

    [NativeName("VK_GPA_SQ_SHADER_STAGE_VS_BIT_AMD")]
    VsBit = 0x2,

    [NativeName("VK_GPA_SQ_SHADER_STAGE_GS_BIT_AMD")]
    GsBit = 0x4,

    [NativeName("VK_GPA_SQ_SHADER_STAGE_ES_BIT_AMD")]
    EsBit = 0x8,

    [NativeName("VK_GPA_SQ_SHADER_STAGE_HS_BIT_AMD")]
    HsBit = 0x10,

    [NativeName("VK_GPA_SQ_SHADER_STAGE_LS_BIT_AMD")]
    LsBit = 0x20,

    [NativeName("VK_GPA_SQ_SHADER_STAGE_CS_BIT_AMD")]
    CsBit = 0x40,
}
