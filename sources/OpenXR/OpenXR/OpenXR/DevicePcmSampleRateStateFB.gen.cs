// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDevicePcmSampleRateStateFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct DevicePcmSampleRateStateFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public StructureType Type = StructureType.DevicePcmSampleRateStateFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public void* Next;

    [NativeName("sampleRate")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public float SampleRate;

    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public DevicePcmSampleRateStateFB() { }
}
