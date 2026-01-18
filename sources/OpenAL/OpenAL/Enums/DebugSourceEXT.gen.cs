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

[NativeName("DebugSourceEXT")]
public enum DebugSourceEXT : uint
{
    [NativeName("AL_DONT_CARE_EXT")]
    DontCare = 2,

    [NativeName("AL_DEBUG_SOURCE_API_EXT")]
    DebugSourceApi = 6581,

    [NativeName("AL_DEBUG_SOURCE_AUDIO_SYSTEM_EXT")]
    DebugSourceAudioSystem = 6582,

    [NativeName("AL_DEBUG_SOURCE_THIRD_PARTY_EXT")]
    DebugSourceThirdParty = 6583,

    [NativeName("AL_DEBUG_SOURCE_APPLICATION_EXT")]
    DebugSourceApplication = 6584,

    [NativeName("AL_DEBUG_SOURCE_OTHER_EXT")]
    DebugSourceOther = 6585,
}
