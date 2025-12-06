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
public enum SourcePName : uint
{
    [NativeName("AL_SOURCE_RELATIVE")]
    SourceRelative = 514,

    [NativeName("AL_CONE_INNER_ANGLE")]
    ConeInnerAngle = 4097,

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = 4098,

    [NativeName("AL_PITCH")]
    Pitch = 4099,

    [NativeName("AL_POSITION")]
    Position = 4100,

    [NativeName("AL_DIRECTION")]
    Direction = 4101,

    [NativeName("AL_VELOCITY")]
    Velocity = 4102,

    [NativeName("AL_LOOPING")]
    Looping = 4103,

    [NativeName("AL_BUFFER")]
    Buffer = 4105,

    [NativeName("AL_GAIN")]
    Gain = 4106,

    [NativeName("AL_MIN_GAIN")]
    MinGain = 4109,

    [NativeName("AL_MAX_GAIN")]
    MaxGain = 4110,

    [NativeName("AL_SOURCE_STATE")]
    SourceState = 4112,

    [NativeName("AL_BUFFERS_QUEUED")]
    BuffersQueued = 4117,

    [NativeName("AL_BUFFERS_PROCESSED")]
    BuffersProcessed = 4118,

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

    [NativeName("AL_CONE_OUTER_GAINHF")]
    ConeOuterGainhf = 131081,

    [NativeName("AL_DIRECT_FILTER_GAINHF_AUTO")]
    DirectFilterGainhfAuto = 131082,

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    AuxiliarySendFilterGainAuto = 131083,

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    AuxiliarySendFilterGainhfAuto = 131084,

    [NativeName("AL_BYTE_RW_OFFSETS_SOFT")]
    ByteRwOffsetsSOFT = 4145,

    [NativeName("AL_SAMPLE_RW_OFFSETS_SOFT")]
    SampleRwOffsetsSOFT = 4146,

    [NativeName("AL_DIRECT_CHANNELS_SOFT")]
    DirectChannelsSOFT = 4147,

    [NativeName("AL_STEREO_ANGLES")]
    StereoAngles = 4144,

    [NativeName("AL_SOURCE_RADIUS")]
    SourceRadius = 4145,

    [NativeName("AL_SAMPLE_OFFSET_LATENCY_SOFT")]
    SampleOffsetLatencySOFT = 4608,

    [NativeName("AL_SEC_OFFSET_LATENCY_SOFT")]
    SecOffsetLatencySOFT = 4609,

    [NativeName("AL_SOURCE_RESAMPLER_SOFT")]
    SourceResamplerSOFT = 4626,

    [NativeName("AL_SOURCE_SPATIALIZE_SOFT")]
    SourceSpatializeSOFT = 4628,

    [NativeName("AL_SAMPLE_OFFSET_CLOCK_SOFT")]
    SampleOffsetClockSOFT = 4610,

    [NativeName("AL_SEC_OFFSET_CLOCK_SOFT")]
    SecOffsetClockSOFT = 4611,

    [NativeName("AL_STEREO_MODE_SOFT")]
    StereoModeSOFT = 6576,

    [NativeName("AL_SUPER_STEREO_WIDTH_SOFT")]
    SuperStereoWidthSOFT = 6577,
}
