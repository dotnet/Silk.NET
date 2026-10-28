// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryToImageCopy")]
public unsafe partial struct MemoryToImageCopy
{
    [NativeName("sType")]
    public StructureType SType = StructureType.MemoryToImageCopy;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pHostPointer")]
    public void* PHostPointer;

    [NativeName("memoryRowLength")]
    public uint MemoryRowLength;

    [NativeName("memoryImageHeight")]
    public uint MemoryImageHeight;

    [NativeName("imageSubresource")]
    public ImageSubresourceLayers ImageSubresource;

    [NativeName("imageOffset")]
    public Offset3D ImageOffset;

    [NativeName("imageExtent")]
    public Extent3D ImageExtent;

    public MemoryToImageCopy() { }
}
