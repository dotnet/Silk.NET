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
[NativeName("DebugSeverityEXT")]
public enum DebugSeverityEXT : uint
{
    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DONT_CARE_EXT")]
    DontCare = unchecked((uint)0x0002),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SEVERITY_HIGH_EXT")]
    DebugSeverityHigh = unchecked((uint)0x19C3),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SEVERITY_MEDIUM_EXT")]
    DebugSeverityMedium = unchecked((uint)0x19C4),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SEVERITY_LOW_EXT")]
    DebugSeverityLow = unchecked((uint)0x19C5),

    [NameAffix("Suffix", "EXT", -1, -1)]
    [NativeName("AL_DEBUG_SEVERITY_NOTIFICATION_EXT")]
    DebugSeverityNotification = unchecked((uint)0x19C6),
}
