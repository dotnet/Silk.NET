// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoCapabilitiesKHR")]
public unsafe partial struct VideoCapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoCapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoCapabilityFlagsKHR Flags;

    [NativeName("minBitstreamBufferOffsetAlignment")]
    public ulong MinBitstreamBufferOffsetAlignment;

    [NativeName("minBitstreamBufferSizeAlignment")]
    public ulong MinBitstreamBufferSizeAlignment;

    [NativeName("pictureAccessGranularity")]
    public Extent2D PictureAccessGranularity;

    [NativeName("minCodedExtent")]
    public Extent2D MinCodedExtent;

    [NativeName("maxCodedExtent")]
    public Extent2D MaxCodedExtent;

    [NativeName("maxDpbSlots")]
    public uint MaxDpbSlots;

    [NativeName("maxActiveReferencePictures")]
    public uint MaxActiveReferencePictures;

    [NativeName("stdHeaderVersion")]
    public ExtensionProperties StdHeaderVersion;

    public VideoCapabilitiesKHR() { }
}
