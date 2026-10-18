// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHapticParametricVibrationEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HapticParametricVibrationEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public StructureType Type = StructureType.HapticParametricVibrationEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public void* Next;

    [NativeName("amplitudePointCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public uint AmplitudePointCount;

    [NativeName("amplitudePoints")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public HapticParametricPointEXT* AmplitudePoints;

    [NativeName("frequencyPointCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public uint FrequencyPointCount;

    [NativeName("frequencyPoints")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public HapticParametricPointEXT* FrequencyPoints;

    [NativeName("transientCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public uint TransientCount;

    [NativeName("transients")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public HapticParametricTransientEXT* Transients;

    [NativeName("minFrequencyHz")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public float MinFrequencyHz;

    [NativeName("maxFrequencyHz")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public float MaxFrequencyHz;

    [NativeName("streamFrameType")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public HapticParametricStreamFrameTypeEXT StreamFrameType;

    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public HapticParametricVibrationEXT() { }
}
