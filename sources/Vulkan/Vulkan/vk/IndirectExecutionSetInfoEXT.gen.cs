// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectExecutionSetInfoEXT")]
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct IndirectExecutionSetInfoEXT
{
    [NativeName("pPipelineInfo")]
    [FieldOffset(0)]
    public IndirectExecutionSetPipelineInfoEXT* PPipelineInfo;

    [NativeName("pShaderInfo")]
    [FieldOffset(0)]
    public IndirectExecutionSetShaderInfoEXT* PShaderInfo;
}
