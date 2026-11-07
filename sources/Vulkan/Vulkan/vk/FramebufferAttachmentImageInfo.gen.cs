// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFramebufferAttachmentImageInfo")]
public unsafe partial struct FramebufferAttachmentImageInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.FramebufferAttachmentImageInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public ImageCreateFlags Flags;

    [NativeName("usage")]
    public ImageUsageFlags Usage;

    [NativeName("width")]
    public uint Width;

    [NativeName("height")]
    public uint Height;

    [NativeName("layerCount")]
    public uint LayerCount;

    [NativeName("viewFormatCount")]
    public uint ViewFormatCount;

    [NativeName("pViewFormats")]
    public Format* PViewFormats;

    public FramebufferAttachmentImageInfo() { }
}
