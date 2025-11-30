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

[NativeName("SourcePName")]
[Transformed]
public enum SourcePName : uint
{
    [NativeName("AL_SOURCE_RELATIVE")]
    SourceRelative = unchecked((uint)0x202),

    [NativeName("AL_CONE_INNER_ANGLE")]
    ConeInnerAngle = unchecked((uint)0x1001),

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = unchecked((uint)0x1002),

    [NativeName("AL_PITCH")]
    Pitch = unchecked((uint)0x1003),

    [NativeName("AL_POSITION")]
    Position = unchecked((uint)0x1004),

    [NativeName("AL_DIRECTION")]
    Direction = unchecked((uint)0x1005),

    [NativeName("AL_VELOCITY")]
    Velocity = unchecked((uint)0x1006),

    [NativeName("AL_LOOPING")]
    Looping = unchecked((uint)0x1007),

    [NativeName("AL_BUFFER")]
    Buffer = unchecked((uint)0x1009),

    [NativeName("AL_GAIN")]
    Gain = unchecked((uint)0x100A),

    [NativeName("AL_MIN_GAIN")]
    MinGain = unchecked((uint)0x100D),

    [NativeName("AL_MAX_GAIN")]
    MaxGain = unchecked((uint)0x100E),

    [NativeName("AL_SOURCE_STATE")]
    SourceState = unchecked((uint)0x1010),

    [NativeName("AL_BUFFERS_QUEUED")]
    BuffersQueued = unchecked((uint)0x1015),

    [NativeName("AL_BUFFERS_PROCESSED")]
    BuffersProcessed = unchecked((uint)0x1016),

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

    [NativeName("AL_SOURCE_TYPE")]
    SourceType = unchecked((uint)0x1027),

    [NativeName("AL_DIRECT_FILTER")]
    DirectFilter = unchecked((uint)0x20005),

    [NativeName("AL_AUXILIARY_SEND_FILTER")]
    AuxiliarySendFilter = unchecked((uint)0x20006),

    [NativeName("AL_AIR_ABSORPTION_FACTOR")]
    AirAbsorptionFactor = unchecked((uint)0x20007),

    [NativeName("AL_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = unchecked((uint)0x20008),

    [NativeName("AL_CONE_OUTER_GAINHF")]
    ConeOuterGainhf = unchecked((uint)0x20009),

    [NativeName("AL_DIRECT_FILTER_GAINHF_AUTO")]
    DirectFilterGainhfAuto = unchecked((uint)0x2000A),

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    AuxiliarySendFilterGainAuto = unchecked((uint)0x2000B),

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    AuxiliarySendFilterGainhfAuto = unchecked((uint)0x2000C),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_BYTE_RW_OFFSETS_SOFT")]
    ByteRwOffsetssoft = unchecked((uint)0x1031),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SAMPLE_RW_OFFSETS_SOFT")]
    SampleRwOffsetssoft = unchecked((uint)0x1032),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_DIRECT_CHANNELS_SOFT")]
    DirectChannelssoft = unchecked((uint)0x1033),

    [NativeName("AL_STEREO_ANGLES")]
    StereoAngles = unchecked((uint)0x1030),

    [NativeName("AL_SOURCE_RADIUS")]
    SourceRadius = unchecked((uint)0x1031),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SAMPLE_OFFSET_LATENCY_SOFT")]
    SampleOffsetLatencysoft = unchecked((uint)0x1200),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SEC_OFFSET_LATENCY_SOFT")]
    SecOffsetLatencysoft = unchecked((uint)0x1201),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SOURCE_RESAMPLER_SOFT")]
    SourceResamplersoft = unchecked((uint)0x1212),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SOURCE_SPATIALIZE_SOFT")]
    SourceSpatializesoft = unchecked((uint)0x1214),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SAMPLE_OFFSET_CLOCK_SOFT")]
    SampleOffsetClocksoft = unchecked((uint)0x1202),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SEC_OFFSET_CLOCK_SOFT")]
    SecOffsetClocksoft = unchecked((uint)0x1203),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_STEREO_MODE_SOFT")]
    StereoModesoft = unchecked((uint)0x19B0),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SUPER_STEREO_WIDTH_SOFT")]
    SuperStereoWidthsoft = unchecked((uint)0x19B1),
}
