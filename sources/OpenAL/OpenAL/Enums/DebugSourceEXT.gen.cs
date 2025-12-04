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

[NameAffix("Suffix", "EXT", 0, -1)]
[NativeName("DebugSourceEXT")]
public enum DebugSourceEXT : uint
{
    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DONT_CARE_EXT")]
    DontCare = unchecked((uint)0x0002),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SOURCE_API_EXT")]
    DebugSourceApi = unchecked((uint)0x19B5),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SOURCE_AUDIO_SYSTEM_EXT")]
    DebugSourceAudioSystem = unchecked((uint)0x19B6),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SOURCE_THIRD_PARTY_EXT")]
    DebugSourceThirdParty = unchecked((uint)0x19B7),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SOURCE_APPLICATION_EXT")]
    DebugSourceApplication = unchecked((uint)0x19B8),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SOURCE_OTHER_EXT")]
    DebugSourceOther = unchecked((uint)0x19B9),
}
