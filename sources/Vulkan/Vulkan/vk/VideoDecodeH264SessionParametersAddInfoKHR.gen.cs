// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeH264SessionParametersAddInfoKHR")]
public unsafe partial struct VideoDecodeH264SessionParametersAddInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoDecodeH264SessionParametersAddInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("stdSPSCount")]
    public uint StdSpsCount;

    [NativeName("pStdSPSs")]
    public StdVideoH264SequenceParameterSet* PStdSPSs;

    [NativeName("stdPPSCount")]
    public uint StdPpsCount;

    [NativeName("pStdPPSs")]
    public StdVideoH264PictureParameterSet* PStdPPSs;

    public VideoDecodeH264SessionParametersAddInfoKHR() { }
}
