// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265GopRemainingFrameInfoKHR")]
public unsafe partial struct VideoEncodeH265GopRemainingFrameInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265GopRemainingFrameInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("useGopRemainingFrames")]
    public MaybeBool<uint> UseGopRemainingFrames;

    [NativeName("gopRemainingI")]
    public uint GopRemainingI;

    [NativeName("gopRemainingP")]
    public uint GopRemainingP;

    [NativeName("gopRemainingB")]
    public uint GopRemainingB;

    public VideoEncodeH265GopRemainingFrameInfoKHR() { }
}
