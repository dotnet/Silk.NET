// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCopyImageToBufferInfo2")]
public unsafe partial struct CopyImageToBufferInfo2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CopyImageToBufferInfo2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcImage")]
    public ImageHandle SrcImage;

    [NativeName("srcImageLayout")]
    public ImageLayout SrcImageLayout;

    [NativeName("dstBuffer")]
    public BufferHandle DstBuffer;

    [NativeName("regionCount")]
    public uint RegionCount;

    [NativeName("pRegions")]
    public BufferImageCopy2* PRegions;

    public CopyImageToBufferInfo2() { }
}
