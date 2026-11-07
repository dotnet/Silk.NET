// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferUsageFlags2CreateInfo")]
public unsafe partial struct BufferUsageFlags2CreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BufferUsageFlags2CreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("usage")]
    public BufferUsageFlags2 Usage;

    public BufferUsageFlags2CreateInfo() { }
}
