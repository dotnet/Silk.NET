// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1SessionParametersCreateInfoKHR")]
public unsafe partial struct VideoEncodeAv1SessionParametersCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeAv1SessionParametersCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pStdSequenceHeader")]
    public StdVideoAv1SequenceHeader* PStdSequenceHeader;

    [NativeName("pStdDecoderModelInfo")]
    public StdVideoEncodeAv1DecoderModelInfo* PStdDecoderModelInfo;

    [NativeName("stdOperatingPointCount")]
    public uint StdOperatingPointCount;

    [NativeName("pStdOperatingPoints")]
    public StdVideoEncodeAv1OperatingPointInfo* PStdOperatingPoints;

    public VideoEncodeAv1SessionParametersCreateInfoKHR() { }
}
