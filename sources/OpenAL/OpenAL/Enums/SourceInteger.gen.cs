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
    ConeInnerAngle = 4097,

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = 4098,

    [NativeName("AL_BUFFER")]
    Buffer = 4105,

    [NativeName("AL_SOURCE_STATE")]
    SourceState = 4112,

    [NativeName("AL_BUFFERS_QUEUED")]
    BuffersQueued = 4117,

    [NativeName("AL_BUFFERS_PROCESSED")]
    BuffersProcessed = 4118,

    [NativeName("AL_SEC_OFFSET")]
    SecOffset = 4132,

    [NativeName("AL_SAMPLE_OFFSET")]
    SampleOffset = 4133,

    [NativeName("AL_BYTE_OFFSET")]
    ByteOffset = 4134,

    [NativeName("AL_SOURCE_TYPE")]
    SourceType = 4135,

    [NativeName("AL_DIRECT_FILTER")]
    DirectFilter = 131077,

    [NativeName("AL_AUXILIARY_SEND_FILTER")]
    AuxiliarySendFilter = 131078,

    [NativeName("AL_AIR_ABSORPTION_FACTOR")]
    AirAbsorptionFactor = 131079,

    [NativeName("AL_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = 131080,

    [NativeName("AL_DIRECT_CHANNELS_SOFT")]
    DirectChannelsSOFT = 4147,

    [NativeName("AL_SAMPLE_OFFSET_LATENCY_SOFT")]
    SampleOffsetLatencySOFT = 4608,

    [NativeName("AL_SOURCE_RESAMPLER_SOFT")]
    SourceResamplerSOFT = 4626,

    [NativeName("AL_SOURCE_SPATIALIZE_SOFT")]
    SourceSpatializeSOFT = 4628,

    [NativeName("AL_SAMPLE_OFFSET_CLOCK_SOFT")]
    SampleOffsetClockSOFT = 4610,

    [NativeName("AL_STEREO_MODE_SOFT")]
    StereoModeSOFT = 6576,
}
