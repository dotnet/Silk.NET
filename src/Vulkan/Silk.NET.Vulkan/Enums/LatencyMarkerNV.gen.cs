// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLatencyMarkerNV")]
    public enum LatencyMarkerNV : int
    {
        [Obsolete("Deprecated in favour of \"SimulationStartNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_SIMULATION_START_NV")]
        LatencyMarkerSimulationStartNV = 0,
        [Obsolete("Deprecated in favour of \"SimulationEndNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_SIMULATION_END_NV")]
        LatencyMarkerSimulationEndNV = 1,
        [Obsolete("Deprecated in favour of \"RendersubmitStartNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_RENDERSUBMIT_START_NV")]
        LatencyMarkerRendersubmitStartNV = 2,
        [Obsolete("Deprecated in favour of \"RendersubmitEndNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_RENDERSUBMIT_END_NV")]
        LatencyMarkerRendersubmitEndNV = 3,
        [Obsolete("Deprecated in favour of \"PresentStartNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_PRESENT_START_NV")]
        LatencyMarkerPresentStartNV = 4,
        [Obsolete("Deprecated in favour of \"PresentEndNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_PRESENT_END_NV")]
        LatencyMarkerPresentEndNV = 5,
        [Obsolete("Deprecated in favour of \"InputSampleNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_INPUT_SAMPLE_NV")]
        LatencyMarkerInputSampleNV = 6,
        [Obsolete("Deprecated in favour of \"TriggerFlashNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_TRIGGER_FLASH_NV")]
        LatencyMarkerTriggerFlashNV = 7,
        [Obsolete("Deprecated in favour of \"OutOfBandRendersubmitStartNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV")]
        LatencyMarkerOutOfBandRendersubmitStartNV = 8,
        [Obsolete("Deprecated in favour of \"OutOfBandRendersubmitEndNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV")]
        LatencyMarkerOutOfBandRendersubmitEndNV = 9,
        [Obsolete("Deprecated in favour of \"OutOfBandPresentStartNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV")]
        LatencyMarkerOutOfBandPresentStartNV = 10,
        [Obsolete("Deprecated in favour of \"OutOfBandPresentEndNV\"")]
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV")]
        LatencyMarkerOutOfBandPresentEndNV = 11,
        [NativeName("Name", "VK_LATENCY_MARKER_SIMULATION_START_NV")]
        SimulationStartNV = 0,
        [NativeName("Name", "VK_LATENCY_MARKER_SIMULATION_END_NV")]
        SimulationEndNV = 1,
        [NativeName("Name", "VK_LATENCY_MARKER_RENDERSUBMIT_START_NV")]
        RendersubmitStartNV = 2,
        [NativeName("Name", "VK_LATENCY_MARKER_RENDERSUBMIT_END_NV")]
        RendersubmitEndNV = 3,
        [NativeName("Name", "VK_LATENCY_MARKER_PRESENT_START_NV")]
        PresentStartNV = 4,
        [NativeName("Name", "VK_LATENCY_MARKER_PRESENT_END_NV")]
        PresentEndNV = 5,
        [NativeName("Name", "VK_LATENCY_MARKER_INPUT_SAMPLE_NV")]
        InputSampleNV = 6,
        [NativeName("Name", "VK_LATENCY_MARKER_TRIGGER_FLASH_NV")]
        TriggerFlashNV = 7,
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV")]
        OutOfBandRendersubmitStartNV = 8,
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV")]
        OutOfBandRendersubmitEndNV = 9,
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV")]
        OutOfBandPresentStartNV = 10,
        [NativeName("Name", "VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV")]
        OutOfBandPresentEndNV = 11,
    }
}
