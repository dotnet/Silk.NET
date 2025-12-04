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

[NativeName("FloatPName")]
public enum FloatPName : uint
{
    [NativeName("AL_DOPPLER_FACTOR")]
    DopplerFactor = unchecked((uint)0xC000),

    [NativeName("AL_DOPPLER_VELOCITY")]
    DopplerVelocity = unchecked((uint)0xC001),

    [NativeName("AL_SPEED_OF_SOUND")]
    SpeedOfSound = unchecked((uint)0xC003),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_DEBUG_LOGGED_MESSAGES_EXT")]
    DebugLoggedMessagesEXT = unchecked((uint)0x19C7),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT")]
    DebugNextLoggedMessageLengthEXT = unchecked((uint)0x19C8),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_MAX_DEBUG_MESSAGE_LENGTH_EXT")]
    MaxDebugMessageLengthEXT = unchecked((uint)0x19C9),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_MAX_DEBUG_LOGGED_MESSAGES_EXT")]
    MaxDebugLoggedMessagesEXT = unchecked((uint)0x19CA),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT")]
    MaxDebugGroupStackDepthEXT = unchecked((uint)0x19CB),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_MAX_LABEL_LENGTH_EXT")]
    MaxLabelLengthEXT = unchecked((uint)0x19CC),
}
