// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeRateControlInfoKHR")]
public unsafe partial struct VideoEncodeRateControlInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeRateControlInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("rateControlMode")]
    public VideoEncodeRateControlModeFlagsKHR RateControlMode;

    [NativeName("layerCount")]
    public uint LayerCount;

    [NativeName("pLayers")]
    public VideoEncodeRateControlLayerInfoKHR* PLayers;

    [NativeName("virtualBufferSizeInMs")]
    public uint VirtualBufferSizeInMs;

    [NativeName("initialVirtualBufferSizeInMs")]
    public uint InitialVirtualBufferSizeInMs;

    public VideoEncodeRateControlInfoKHR() { }
}
