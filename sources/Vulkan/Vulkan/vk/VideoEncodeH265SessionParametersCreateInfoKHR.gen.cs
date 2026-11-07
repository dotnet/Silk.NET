// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265SessionParametersCreateInfoKHR")]
public unsafe partial struct VideoEncodeH265SessionParametersCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265SessionParametersCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxStdVPSCount")]
    public uint MaxStdVpsCount;

    [NativeName("maxStdSPSCount")]
    public uint MaxStdSpsCount;

    [NativeName("maxStdPPSCount")]
    public uint MaxStdPpsCount;

    [NativeName("pParametersAddInfo")]
    public VideoEncodeH265SessionParametersAddInfoKHR* PParametersAddInfo;

    public VideoEncodeH265SessionParametersCreateInfoKHR() { }
}
