// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryMapInfo")]
public unsafe partial struct MemoryMapInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.MemoryMapInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public MemoryMapFlags Flags;

    [NativeName("memory")]
    public DeviceMemoryHandle Memory;

    [NativeName("offset")]
    public ulong Offset;

    [NativeName("size")]
    public ulong Size;

    public MemoryMapInfo() { }
}
