// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassDependency2")]
public unsafe partial struct SubpassDependency2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SubpassDependency2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcSubpass")]
    public uint SrcSubpass;

    [NativeName("dstSubpass")]
    public uint DstSubpass;

    [NativeName("srcStageMask")]
    public PipelineStageFlags SrcStageMask;

    [NativeName("dstStageMask")]
    public PipelineStageFlags DstStageMask;

    [NativeName("srcAccessMask")]
    public AccessFlags SrcAccessMask;

    [NativeName("dstAccessMask")]
    public AccessFlags DstAccessMask;

    [NativeName("dependencyFlags")]
    public DependencyFlags DependencyFlags;

    [NativeName("viewOffset")]
    public int ViewOffset;

    public SubpassDependency2() { }
}
