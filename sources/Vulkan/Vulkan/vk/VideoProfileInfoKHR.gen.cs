// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoProfileInfoKHR")]
public unsafe partial struct VideoProfileInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoProfileInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("videoCodecOperation")]
    public VideoCodecOperationFlagsKHR VideoCodecOperation;

    [NativeName("chromaSubsampling")]
    public VideoChromaSubsamplingFlagsKHR ChromaSubsampling;

    [NativeName("lumaBitDepth")]
    public VideoComponentBitDepthFlagsKHR LumaBitDepth;

    [NativeName("chromaBitDepth")]
    public VideoComponentBitDepthFlagsKHR ChromaBitDepth;

    public VideoProfileInfoKHR() { }
}
