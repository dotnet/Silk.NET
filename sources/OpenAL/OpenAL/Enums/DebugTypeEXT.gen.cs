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

[NativeName("DebugTypeEXT")]
public enum DebugTypeEXT : uint
{
    [NativeName("AL_DONT_CARE_EXT")]
    DontCareEXT = unchecked((uint)0x0002),

    [NativeName("AL_DEBUG_TYPE_ERROR_EXT")]
    DebugTypeErrorEXT = unchecked((uint)0x19BA),

    [NativeName("AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT")]
    DebugTypeDeprecatedBehaviorEXT = unchecked((uint)0x19BB),

    [NativeName("AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT")]
    DebugTypeUndefinedBehaviorEXT = unchecked((uint)0x19BC),

    [NativeName("AL_DEBUG_TYPE_PORTABILITY_EXT")]
    DebugTypePortabilityEXT = unchecked((uint)0x19BD),

    [NativeName("AL_DEBUG_TYPE_PERFORMANCE_EXT")]
    DebugTypePerformanceEXT = unchecked((uint)0x19BE),

    [NativeName("AL_DEBUG_TYPE_MARKER_EXT")]
    DebugTypeMarkerEXT = unchecked((uint)0x19BF),

    [NativeName("AL_DEBUG_TYPE_PUSH_GROUP_EXT")]
    DebugTypePushGroupEXT = unchecked((uint)0x19C0),

    [NativeName("AL_DEBUG_TYPE_POP_GROUP_EXT")]
    DebugTypePopGroupEXT = unchecked((uint)0x19C1),

    [NativeName("AL_DEBUG_TYPE_OTHER_EXT")]
    DebugTypeOtherEXT = unchecked((uint)0x19C2),
}
