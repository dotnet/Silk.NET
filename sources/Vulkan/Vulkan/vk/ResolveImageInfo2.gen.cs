// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkResolveImageInfo2")]
public unsafe partial struct ResolveImageInfo2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ResolveImageInfo2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcImage")]
    public ImageHandle SrcImage;

    [NativeName("srcImageLayout")]
    public ImageLayout SrcImageLayout;

    [NativeName("dstImage")]
    public ImageHandle DstImage;

    [NativeName("dstImageLayout")]
    public ImageLayout DstImageLayout;

    [NativeName("regionCount")]
    public uint RegionCount;

    [NativeName("pRegions")]
    public ImageResolve2* PRegions;

    public ResolveImageInfo2() { }
}
