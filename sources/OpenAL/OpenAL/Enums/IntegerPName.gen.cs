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

[NativeName("IntegerPName")]
public enum IntegerPName : uint
{
    [NativeName("AL_DISTANCE_MODEL")]
    DistanceModel = 53248,

    [NativeName("AL_GAIN_LIMIT_SOFT")]
    GainLimitSOFT = 8206,

    [NativeName("AL_NUM_RESAMPLERS_SOFT")]
    NumResamplersSOFT = 4624,

    [NativeName("AL_DEFAULT_RESAMPLER_SOFT")]
    DefaultResamplerSOFT = 4625,

    [NativeName("AL_DEBUG_LOGGED_MESSAGES_EXT")]
    DebugLoggedMessagesEXT = 6599,

    [NativeName("AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT")]
    DebugNextLoggedMessageLengthEXT = 6600,

    [NativeName("AL_MAX_DEBUG_MESSAGE_LENGTH_EXT")]
    MaxDebugMessageLengthEXT = 6601,

    [NativeName("AL_MAX_DEBUG_LOGGED_MESSAGES_EXT")]
    MaxDebugLoggedMessagesEXT = 6602,

    [NativeName("AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT")]
    MaxDebugGroupStackDepthEXT = 6603,

    [NativeName("AL_MAX_LABEL_LENGTH_EXT")]
    MaxLabelLengthEXT = 6604,

    [NativeName("AL_CONTEXT_FLAGS_EXT")]
    ContextFlagsEXT = 6607,
}
