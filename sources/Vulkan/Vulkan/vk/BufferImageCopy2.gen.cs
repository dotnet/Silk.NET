// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferImageCopy2")]
public unsafe partial struct BufferImageCopy2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BufferImageCopy2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("bufferOffset")]
    public ulong BufferOffset;

    [NativeName("bufferRowLength")]
    public uint BufferRowLength;

    [NativeName("bufferImageHeight")]
    public uint BufferImageHeight;

    [NativeName("imageSubresource")]
    public ImageSubresourceLayers ImageSubresource;

    [NativeName("imageOffset")]
    public Offset3D ImageOffset;

    [NativeName("imageExtent")]
    public Extent3D ImageExtent;

    public BufferImageCopy2() { }
}
