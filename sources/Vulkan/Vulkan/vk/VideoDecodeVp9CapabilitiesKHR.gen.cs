// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeVP9CapabilitiesKHR")]
public unsafe partial struct VideoDecodeVp9CapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoDecodeVp9CapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxLevel")]
    public StdVideoVp9Level MaxLevel;

    public VideoDecodeVp9CapabilitiesKHR() { }
}
