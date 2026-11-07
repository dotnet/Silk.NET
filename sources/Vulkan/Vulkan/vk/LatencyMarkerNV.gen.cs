// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLatencyMarkerNV")]
public enum LatencyMarkerNV : uint
{
    [NativeName("VK_LATENCY_MARKER_SIMULATION_START_NV")]
    SimulationStart = 0,

    [NativeName("VK_LATENCY_MARKER_SIMULATION_END_NV")]
    SimulationEnd = 1,

    [NativeName("VK_LATENCY_MARKER_RENDERSUBMIT_START_NV")]
    RendersubmitStart = 2,

    [NativeName("VK_LATENCY_MARKER_RENDERSUBMIT_END_NV")]
    RendersubmitEnd = 3,

    [NativeName("VK_LATENCY_MARKER_PRESENT_START_NV")]
    PresentStart = 4,

    [NativeName("VK_LATENCY_MARKER_PRESENT_END_NV")]
    PresentEnd = 5,

    [NativeName("VK_LATENCY_MARKER_INPUT_SAMPLE_NV")]
    InputSample = 6,

    [NativeName("VK_LATENCY_MARKER_TRIGGER_FLASH_NV")]
    TriggerFlash = 7,

    [NativeName("VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV")]
    OutOfBandRendersubmitStart = 8,

    [NativeName("VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV")]
    OutOfBandRendersubmitEnd = 9,

    [NativeName("VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV")]
    OutOfBandPresentStart = 10,

    [NativeName("VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV")]
    OutOfBandPresentEnd = 11,
}
