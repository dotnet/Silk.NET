// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandBufferInheritanceViewportScissorInfoNV")]
public unsafe partial struct CommandBufferInheritanceViewportScissorInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CommandBufferInheritanceViewportScissorInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("viewportScissor2D")]
    public MaybeBool<uint> ViewportScissor2D;

    [NativeName("viewportDepthCount")]
    public uint ViewportDepthCount;

    [NativeName("pViewportDepths")]
    public Viewport* PViewportDepths;

    public CommandBufferInheritanceViewportScissorInfoNV() { }
}
