// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NativeName("SourceFloat")]
public enum SourceFloat : uint
{
    [NativeName("AL_CONE_INNER_ANGLE")]
    ConeInnerAngle = 4097,

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = 4098,

    [NativeName("AL_PITCH")]
    Pitch = 4099,

    [NativeName("AL_GAIN")]
    Gain = 4106,

    [NativeName("AL_MIN_GAIN")]
    MinGain = 4109,

    [NativeName("AL_MAX_GAIN")]
    MaxGain = 4110,

    [NativeName("AL_REFERENCE_DISTANCE")]
    ReferenceDistance = 4128,

    [NativeName("AL_ROLLOFF_FACTOR")]
    RolloffFactor = 4129,

    [NativeName("AL_MAX_DISTANCE")]
    MaxDistance = 4131,

    [NativeName("AL_SEC_OFFSET")]
    SecOffset = 4132,

    [NativeName("AL_SAMPLE_OFFSET")]
    SampleOffset = 4133,

    [NativeName("AL_BYTE_OFFSET")]
    ByteOffset = 4134,

    [NativeName("AL_CONE_OUTER_GAINHF")]
    ConeOuterGainhf = 131081,

    [NativeName("AL_BYTE_RW_OFFSETS_SOFT")]
    ByteRwOffsetsSOFT = 4145,

    [NativeName("AL_SAMPLE_RW_OFFSETS_SOFT")]
    SampleRwOffsetsSOFT = 4146,

    [NativeName("AL_STEREO_ANGLES")]
    StereoAngles = 4144,

    [NativeName("AL_SOURCE_RADIUS")]
    SourceRadius = 4145,

    [NativeName("AL_SEC_OFFSET_LATENCY_SOFT")]
    SecOffsetLatencySOFT = 4609,

    [NativeName("AL_SUPER_STEREO_WIDTH_SOFT")]
    SuperStereoWidthSOFT = 6577,
}
