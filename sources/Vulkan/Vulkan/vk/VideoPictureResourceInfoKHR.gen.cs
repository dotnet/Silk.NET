// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoPictureResourceInfoKHR")]
public unsafe partial struct VideoPictureResourceInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoPictureResourceInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("codedOffset")]
    public Offset2D CodedOffset;

    [NativeName("codedExtent")]
    public Extent2D CodedExtent;

    [NativeName("baseArrayLayer")]
    public uint BaseArrayLayer;

    [NativeName("imageViewBinding")]
    public ImageViewHandle ImageViewBinding;

    public VideoPictureResourceInfoKHR() { }
}
