// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeH264CapabilitiesKHR")]
public unsafe partial struct VideoDecodeH264CapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoDecodeH264CapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxLevelIdc")]
    public StdVideoH264LevelIdc MaxLevelIdc;

    [NativeName("fieldOffsetGranularity")]
    public Offset2D FieldOffsetGranularity;

    public VideoDecodeH264CapabilitiesKHR() { }
}
