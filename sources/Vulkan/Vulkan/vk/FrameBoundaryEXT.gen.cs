// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFrameBoundaryEXT")]
public unsafe partial struct FrameBoundaryEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.FrameBoundaryEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public FrameBoundaryFlagsEXT Flags;

    [NativeName("frameID")]
    public ulong FrameID;

    [NativeName("imageCount")]
    public uint ImageCount;

    [NativeName("pImages")]
    public ImageHandle* PImages;

    [NativeName("bufferCount")]
    public uint BufferCount;

    [NativeName("pBuffers")]
    public BufferHandle* PBuffers;

    [NativeName("tagName")]
    public ulong TagName;

    [NativeName("tagSize")]
    public nuint TagSize;

    [NativeName("pTag")]
    public void* PTag;

    public FrameBoundaryEXT() { }
}
