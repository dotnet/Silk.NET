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

[NativeName("BufferInteger")]
public enum BufferInteger : uint
{
    [NativeName("AL_FREQUENCY")]
    Frequency = 8193,

    [NativeName("AL_SIZE")]
    Size = 8196,

    [NativeName("AL_BITS")]
    Bits = 8194,

    [NativeName("AL_CHANNELS")]
    Channels = 8195,

    [NativeName("AL_LOOP_POINTS_SOFT")]
    LoopPointsSOFT = 8213,

    [NativeName("AL_INTERNAL_FORMAT_SOFT")]
    InternalFormatSOFT = 8200,

    [NativeName("AL_BYTE_LENGTH_SOFT")]
    ByteLengthSOFT = 8201,

    [NativeName("AL_SAMPLE_LENGTH_SOFT")]
    SampleLengthSOFT = 8202,

    [NativeName("AL_UNPACK_BLOCK_ALIGNMENT_SOFT")]
    UnpackBlockAlignmentSOFT = 8204,

    [NativeName("AL_PACK_BLOCK_ALIGNMENT_SOFT")]
    PackBlockAlignmentSOFT = 8205,

    [NativeName("AL_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutSOFT = 6551,

    [NativeName("AL_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingSOFT = 6552,

    [NativeName("AL_UNPACK_AMBISONIC_ORDER_SOFT")]
    UnpackAmbisonicOrderSOFT = 6557,
}
