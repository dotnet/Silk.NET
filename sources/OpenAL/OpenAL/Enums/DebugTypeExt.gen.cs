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

[NameAffix("Suffix", "EXT", 0)]
[NativeName("DebugTypeEXT")]
[Transformed]
public enum DebugTypeExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DONT_CARE_EXT")]
    DontCareext = unchecked((uint)0x0002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_ERROR_EXT")]
    DebugTypeErrorext = unchecked((uint)0x19BA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT")]
    DebugTypeDeprecatedBehaviorext = unchecked((uint)0x19BB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT")]
    DebugTypeUndefinedBehaviorext = unchecked((uint)0x19BC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_PORTABILITY_EXT")]
    DebugTypePortabilityext = unchecked((uint)0x19BD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_PERFORMANCE_EXT")]
    DebugTypePerformanceext = unchecked((uint)0x19BE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_MARKER_EXT")]
    DebugTypeMarkerext = unchecked((uint)0x19BF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_PUSH_GROUP_EXT")]
    DebugTypePushGroupext = unchecked((uint)0x19C0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_POP_GROUP_EXT")]
    DebugTypePopGroupext = unchecked((uint)0x19C1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("AL_DEBUG_TYPE_OTHER_EXT")]
    DebugTypeOtherext = unchecked((uint)0x19C2),
}
