// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeH265InlineSessionParametersInfoKHR")]
public unsafe partial struct VideoDecodeH265InlineSessionParametersInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoDecodeH265InlineSessionParametersInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pStdVPS")]
    public StdVideoH265VideoParameterSet* PStdVps;

    [NativeName("pStdSPS")]
    public StdVideoH265SequenceParameterSet* PStdSps;

    [NativeName("pStdPPS")]
    public StdVideoH265PictureParameterSet* PStdPps;

    public VideoDecodeH265InlineSessionParametersInfoKHR() { }
}
