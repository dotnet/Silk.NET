// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264SessionParametersCreateInfoKHR")]
public unsafe partial struct VideoEncodeH264SessionParametersCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH264SessionParametersCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxStdSPSCount")]
    public uint MaxStdSpsCount;

    [NativeName("maxStdPPSCount")]
    public uint MaxStdPpsCount;

    [NativeName("pParametersAddInfo")]
    public VideoEncodeH264SessionParametersAddInfoKHR* PParametersAddInfo;

    public VideoEncodeH264SessionParametersCreateInfoKHR() { }
}
