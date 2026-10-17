// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHapticAmplitudeEnvelopeVibrationFB")]
public unsafe partial struct HapticAmplitudeEnvelopeVibrationFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.HapticAmplitudeEnvelopeVibrationFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("duration")]
    public long Duration;

    [NativeName("amplitudeCount")]
    public uint AmplitudeCount;

    [NativeName("amplitudes")]
    public float* Amplitudes;

    public HapticAmplitudeEnvelopeVibrationFB() { }
}
