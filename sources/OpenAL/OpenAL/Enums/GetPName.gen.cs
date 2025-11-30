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

[NativeName("GetPName")]
[Transformed]
public enum GetPName : uint
{
    [NativeName("AL_VENDOR")]
    Vendor = unchecked((uint)0xB001),

    [NativeName("AL_VERSION")]
    Version = unchecked((uint)0xB002),

    [NativeName("AL_RENDERER")]
    Renderer = unchecked((uint)0xB003),

    [NativeName("AL_EXTENSIONS")]
    Extensions = unchecked((uint)0xB004),

    [NativeName("AL_DOPPLER_FACTOR")]
    DopplerFactor = unchecked((uint)0xC000),

    [NativeName("AL_DOPPLER_VELOCITY")]
    DopplerVelocity = unchecked((uint)0xC001),

    [NativeName("AL_DISTANCE_MODEL")]
    DistanceModel = unchecked((uint)0xD000),

    [NativeName("AL_SPEED_OF_SOUND")]
    SpeedOfSound = unchecked((uint)0xC003),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_DEFERRED_UPDATES_SOFT")]
    DeferredUpdatessoft = unchecked((uint)0xC002),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_GAIN_LIMIT_SOFT")]
    GainLimitsoft = unchecked((uint)0x200E),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_NUM_RESAMPLERS_SOFT")]
    NumResamplerssoft = unchecked((uint)0x1210),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_DEFAULT_RESAMPLER_SOFT")]
    DefaultResamplersoft = unchecked((uint)0x1211),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_RESAMPLER_NAME_SOFT")]
    ResamplerNamesoft = unchecked((uint)0x1213),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_EVENT_CALLBACK_FUNCTION_SOFT")]
    EventCallbackFunctionsoft = unchecked((uint)0x19A2),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_EVENT_CALLBACK_USER_PARAM_SOFT")]
    EventCallbackUserParamsoft = unchecked((uint)0x19A3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_LOGGED_MESSAGES_EXT")]
    DebugLoggedMessagesext = unchecked((uint)0x19C7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT")]
    DebugNextLoggedMessageLengthext = unchecked((uint)0x19C8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_MAX_DEBUG_MESSAGE_LENGTH_EXT")]
    MaxDebugMessageLengthext = unchecked((uint)0x19C9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_MAX_DEBUG_LOGGED_MESSAGES_EXT")]
    MaxDebugLoggedMessagesext = unchecked((uint)0x19CA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT")]
    MaxDebugGroupStackDepthext = unchecked((uint)0x19CB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_MAX_LABEL_LENGTH_EXT")]
    MaxLabelLengthext = unchecked((uint)0x19CC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_CONTEXT_FLAGS_EXT")]
    ContextFlagsext = unchecked((uint)0x19CF),
}
