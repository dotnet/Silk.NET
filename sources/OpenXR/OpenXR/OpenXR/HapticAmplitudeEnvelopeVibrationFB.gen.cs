// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHapticAmplitudeEnvelopeVibrationFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HapticAmplitudeEnvelopeVibrationFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public StructureType Type = StructureType.TypeHapticAmplitudeEnvelopeVibrationFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public void* Next;

    [NativeName("duration")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public long Duration;

    [NativeName("amplitudeCount")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public uint AmplitudeCount;

    [NativeName("amplitudes")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public float* Amplitudes;

    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public HapticAmplitudeEnvelopeVibrationFB() { }
}
