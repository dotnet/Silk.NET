// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageCreateInfo")]
public unsafe partial struct ImageCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ImageCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public ImageCreateFlags Flags;

    [NativeName("imageType")]
    public ImageType ImageType;

    [NativeName("format")]
    public Format Format;

    [NativeName("extent")]
    public Extent3D Extent;

    [NativeName("mipLevels")]
    public uint MipLevels;

    [NativeName("arrayLayers")]
    public uint ArrayLayers;

    [NativeName("samples")]
    public SampleCountFlags Samples;

    [NativeName("tiling")]
    public ImageTiling Tiling;

    [NativeName("usage")]
    public ImageUsageFlags Usage;

    [NativeName("sharingMode")]
    public SharingMode SharingMode;

    [NativeName("queueFamilyIndexCount")]
    public uint QueueFamilyIndexCount;

    [NativeName("pQueueFamilyIndices")]
    public uint* PQueueFamilyIndices;

    [NativeName("initialLayout")]
    public ImageLayout InitialLayout;

    public ImageCreateInfo() { }
}
