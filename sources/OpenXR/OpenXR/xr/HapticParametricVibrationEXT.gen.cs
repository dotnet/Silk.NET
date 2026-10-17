// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHapticParametricVibrationEXT")]
public unsafe partial struct HapticParametricVibrationEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.HapticParametricVibrationEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("amplitudePointCount")]
    public uint AmplitudePointCount;

    [NativeName("amplitudePoints")]
    public HapticParametricPointEXT* AmplitudePoints;

    [NativeName("frequencyPointCount")]
    public uint FrequencyPointCount;

    [NativeName("frequencyPoints")]
    public HapticParametricPointEXT* FrequencyPoints;

    [NativeName("transientCount")]
    public uint TransientCount;

    [NativeName("transients")]
    public HapticParametricTransientEXT* Transients;

    [NativeName("minFrequencyHz")]
    public float MinFrequencyHz;

    [NativeName("maxFrequencyHz")]
    public float MaxFrequencyHz;

    [NativeName("streamFrameType")]
    public HapticParametricStreamFrameTypeEXT StreamFrameType;

    public HapticParametricVibrationEXT() { }
}
