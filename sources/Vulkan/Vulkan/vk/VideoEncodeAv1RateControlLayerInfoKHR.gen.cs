// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1RateControlLayerInfoKHR")]
public unsafe partial struct VideoEncodeAv1RateControlLayerInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeAv1RateControlLayerInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("useMinQIndex")]
    public MaybeBool<uint> UseMinQIndex;

    [NativeName("minQIndex")]
    public VideoEncodeAv1QIndexKHR MinQIndex;

    [NativeName("useMaxQIndex")]
    public MaybeBool<uint> UseMaxQIndex;

    [NativeName("maxQIndex")]
    public VideoEncodeAv1QIndexKHR MaxQIndex;

    [NativeName("useMaxFrameSize")]
    public MaybeBool<uint> UseMaxFrameSize;

    [NativeName("maxFrameSize")]
    public VideoEncodeAv1FrameSizeKHR MaxFrameSize;

    public VideoEncodeAv1RateControlLayerInfoKHR() { }
}
