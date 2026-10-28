// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferCreateInfo")]
public unsafe partial struct BufferCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BufferCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public BufferCreateFlags Flags;

    [NativeName("size")]
    public ulong Size;

    [NativeName("usage")]
    public BufferUsageFlags Usage;

    [NativeName("sharingMode")]
    public SharingMode SharingMode;

    [NativeName("queueFamilyIndexCount")]
    public uint QueueFamilyIndexCount;

    [NativeName("pQueueFamilyIndices")]
    public uint* PQueueFamilyIndices;

    public BufferCreateInfo() { }
}
