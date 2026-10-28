// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264RateControlLayerInfoKHR")]
public unsafe partial struct VideoEncodeH264RateControlLayerInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH264RateControlLayerInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("useMinQp")]
    public MaybeBool<uint> UseMinQp;

    [NativeName("minQp")]
    public VideoEncodeH264QpKHR MinQp;

    [NativeName("useMaxQp")]
    public MaybeBool<uint> UseMaxQp;

    [NativeName("maxQp")]
    public VideoEncodeH264QpKHR MaxQp;

    [NativeName("useMaxFrameSize")]
    public MaybeBool<uint> UseMaxFrameSize;

    [NativeName("maxFrameSize")]
    public VideoEncodeH264FrameSizeKHR MaxFrameSize;

    public VideoEncodeH264RateControlLayerInfoKHR() { }
}
