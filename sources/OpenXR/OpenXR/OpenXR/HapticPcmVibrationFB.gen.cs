// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHapticPcmVibrationFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HapticPcmVibrationFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public StructureType Type = StructureType.TypeHapticPcmVibrationFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public void* Next;

    [NativeName("bufferSize")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public uint BufferSize;

    [NativeName("buffer")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public float* Buffer;

    [NativeName("sampleRate")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public float SampleRate;

    [NativeName("append")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public MaybeBool<uint> Append;

    [NativeName("samplesConsumed")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public uint* SamplesConsumed;

    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public HapticPcmVibrationFB() { }
}
