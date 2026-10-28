// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsTokenDataEXT")]
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct IndirectCommandsTokenDataEXT
{
    [NativeName("pPushConstant")]
    [FieldOffset(0)]
    public IndirectCommandsPushConstantTokenEXT* PPushConstant;

    [NativeName("pVertexBuffer")]
    [FieldOffset(0)]
    public IndirectCommandsVertexBufferTokenEXT* PVertexBuffer;

    [NativeName("pIndexBuffer")]
    [FieldOffset(0)]
    public IndirectCommandsIndexBufferTokenEXT* PIndexBuffer;

    [NativeName("pExecutionSet")]
    [FieldOffset(0)]
    public IndirectCommandsExecutionSetTokenEXT* PExecutionSet;
}
