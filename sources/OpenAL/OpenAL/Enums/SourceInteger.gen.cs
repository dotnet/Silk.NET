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

[NativeName("SourceInteger")]
public enum SourceInteger : uint
{
    [NativeName("AL_CONE_INNER_ANGLE")]
    ConeInnerAngle = unchecked((uint)0x1001),

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = unchecked((uint)0x1002),

    [NativeName("AL_BUFFER")]
    Buffer = unchecked((uint)0x1009),

    [NativeName("AL_SOURCE_STATE")]
    SourceState = unchecked((uint)0x1010),

    [NativeName("AL_BUFFERS_QUEUED")]
    BuffersQueued = unchecked((uint)0x1015),

    [NativeName("AL_BUFFERS_PROCESSED")]
    BuffersProcessed = unchecked((uint)0x1016),

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

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_DIRECT_CHANNELS_SOFT")]
    DirectChannelsSOFT = unchecked((uint)0x1033),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_SAMPLE_OFFSET_LATENCY_SOFT")]
    SampleOffsetLatencySOFT = unchecked((uint)0x1200),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_SOURCE_RESAMPLER_SOFT")]
    SourceResamplerSOFT = unchecked((uint)0x1212),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_SOURCE_SPATIALIZE_SOFT")]
    SourceSpatializeSOFT = unchecked((uint)0x1214),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_SAMPLE_OFFSET_CLOCK_SOFT")]
    SampleOffsetClockSOFT = unchecked((uint)0x1202),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_STEREO_MODE_SOFT")]
    StereoModeSOFT = unchecked((uint)0x19B0),
}
