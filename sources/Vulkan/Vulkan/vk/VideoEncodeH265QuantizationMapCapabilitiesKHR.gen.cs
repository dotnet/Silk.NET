// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265QuantizationMapCapabilitiesKHR")]
public unsafe partial struct VideoEncodeH265QuantizationMapCapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265QuantizationMapCapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("minQpDelta")]
    public int MinQpDelta;

    [NativeName("maxQpDelta")]
    public int MaxQpDelta;

    public VideoEncodeH265QuantizationMapCapabilitiesKHR() { }
}
