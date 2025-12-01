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
    ConeInnerAngle = unchecked((uint)0x1001),

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = unchecked((uint)0x1002),

    [NativeName("AL_PITCH")]
    Pitch = unchecked((uint)0x1003),

    [NativeName("AL_GAIN")]
    Gain = unchecked((uint)0x100A),

    [NativeName("AL_MIN_GAIN")]
    MinGain = unchecked((uint)0x100D),

    [NativeName("AL_MAX_GAIN")]
    MaxGain = unchecked((uint)0x100E),

    [NativeName("AL_REFERENCE_DISTANCE")]
    ReferenceDistance = unchecked((uint)0x1020),

    [NativeName("AL_ROLLOFF_FACTOR")]
    RolloffFactor = unchecked((uint)0x1021),

    [NativeName("AL_MAX_DISTANCE")]
    MaxDistance = unchecked((uint)0x1023),

    [NativeName("AL_SEC_OFFSET")]
    SecOffset = unchecked((uint)0x1024),

    [NativeName("AL_SAMPLE_OFFSET")]
    SampleOffset = unchecked((uint)0x1025),

    [NativeName("AL_BYTE_OFFSET")]
    ByteOffset = unchecked((uint)0x1026),

    [NativeName("AL_CONE_OUTER_GAINHF")]
    ConeOuterGainhf = unchecked((uint)0x20009),

    [NativeName("AL_BYTE_RW_OFFSETS_SOFT")]
    ByteRwOffsetsSOFT = unchecked((uint)0x1031),

    [NativeName("AL_SAMPLE_RW_OFFSETS_SOFT")]
    SampleRwOffsetsSOFT = unchecked((uint)0x1032),

    [NativeName("AL_STEREO_ANGLES")]
    StereoAngles = unchecked((uint)0x1030),

    [NativeName("AL_SOURCE_RADIUS")]
    SourceRadius = unchecked((uint)0x1031),

    [NativeName("AL_SEC_OFFSET_LATENCY_SOFT")]
    SecOffsetLatencySOFT = unchecked((uint)0x1201),

    [NativeName("AL_SUPER_STEREO_WIDTH_SOFT")]
    SuperStereoWidthSOFT = unchecked((uint)0x19B1),
}
