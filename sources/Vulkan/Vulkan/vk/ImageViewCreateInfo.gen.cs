// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageViewCreateInfo")]
public unsafe partial struct ImageViewCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ImageViewCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public ImageViewCreateFlags Flags;

    [NativeName("image")]
    public ImageHandle Image;

    [NativeName("viewType")]
    public ImageViewType ViewType;

    [NativeName("format")]
    public Format Format;

    [NativeName("components")]
    public ComponentMapping Components;

    [NativeName("subresourceRange")]
    public ImageSubresourceRange SubresourceRange;

    public ImageViewCreateInfo() { }
}
