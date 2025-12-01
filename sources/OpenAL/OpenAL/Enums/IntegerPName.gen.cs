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
    DistanceModel = unchecked((uint)0xD000),

    [NativeName("AL_GAIN_LIMIT_SOFT")]
    GainLimitSOFT = unchecked((uint)0x200E),

    [NativeName("AL_NUM_RESAMPLERS_SOFT")]
    NumResamplersSOFT = unchecked((uint)0x1210),

    [NativeName("AL_DEFAULT_RESAMPLER_SOFT")]
    DefaultResamplerSOFT = unchecked((uint)0x1211),

    [NativeName("AL_DEBUG_LOGGED_MESSAGES_EXT")]
    DebugLoggedMessagesEXT = unchecked((uint)0x19C7),

    [NativeName("AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT")]
    DebugNextLoggedMessageLengthEXT = unchecked((uint)0x19C8),

    [NativeName("AL_MAX_DEBUG_MESSAGE_LENGTH_EXT")]
    MaxDebugMessageLengthEXT = unchecked((uint)0x19C9),

    [NativeName("AL_MAX_DEBUG_LOGGED_MESSAGES_EXT")]
    MaxDebugLoggedMessagesEXT = unchecked((uint)0x19CA),

    [NativeName("AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT")]
    MaxDebugGroupStackDepthEXT = unchecked((uint)0x19CB),

    [NativeName("AL_MAX_LABEL_LENGTH_EXT")]
    MaxLabelLengthEXT = unchecked((uint)0x19CC),

    [NativeName("AL_CONTEXT_FLAGS_EXT")]
    ContextFlagsEXT = unchecked((uint)0x19CF),
}
