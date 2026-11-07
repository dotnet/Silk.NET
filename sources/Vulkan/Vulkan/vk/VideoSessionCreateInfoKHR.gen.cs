// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoSessionCreateInfoKHR")]
public unsafe partial struct VideoSessionCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoSessionCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("queueFamilyIndex")]
    public uint QueueFamilyIndex;

    [NativeName("flags")]
    public VideoSessionCreateFlagsKHR Flags;

    [NativeName("pVideoProfile")]
    public VideoProfileInfoKHR* PVideoProfile;

    [NativeName("pictureFormat")]
    public Format PictureFormat;

    [NativeName("maxCodedExtent")]
    public Extent2D MaxCodedExtent;

    [NativeName("referencePictureFormat")]
    public Format ReferencePictureFormat;

    [NativeName("maxDpbSlots")]
    public uint MaxDpbSlots;

    [NativeName("maxActiveReferencePictures")]
    public uint MaxActiveReferencePictures;

    [NativeName("pStdHeaderVersion")]
    public ExtensionProperties* PStdHeaderVersion;

    public VideoSessionCreateInfoKHR() { }
}
