// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryBarrierAccessFlags3KHR")]
public unsafe partial struct MemoryBarrierAccessFlags3KHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.MemoryBarrierAccessFlags3KHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcAccessMask3")]
    public AccessFlags3KHR SrcAccessMask3;

    [NativeName("dstAccessMask3")]
    public AccessFlags3KHR DstAccessMask3;

    public MemoryBarrierAccessFlags3KHR() { }
}
