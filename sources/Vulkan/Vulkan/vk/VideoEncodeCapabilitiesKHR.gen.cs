// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeCapabilitiesKHR")]
public unsafe partial struct VideoEncodeCapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeCapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public VideoEncodeCapabilityFlagsKHR Flags;

    [NativeName("rateControlModes")]
    public VideoEncodeRateControlModeFlagsKHR RateControlModes;

    [NativeName("maxRateControlLayers")]
    public uint MaxRateControlLayers;

    [NativeName("maxBitrate")]
    public ulong MaxBitrate;

    [NativeName("maxQualityLevels")]
    public uint MaxQualityLevels;

    [NativeName("encodeInputPictureGranularity")]
    public Extent2D EncodeInputPictureGranularity;

    [NativeName("supportedEncodeFeedbackFlags")]
    public VideoEncodeFeedbackFlagsKHR SupportedEncodeFeedbackFlags;

    public VideoEncodeCapabilitiesKHR() { }
}
