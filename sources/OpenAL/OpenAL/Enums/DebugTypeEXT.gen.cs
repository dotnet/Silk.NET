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
    DontCare = 2,

    [NativeName("AL_DEBUG_TYPE_ERROR_EXT")]
    DebugTypeError = 6586,

    [NativeName("AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT")]
    DebugTypeDeprecatedBehavior = 6587,

    [NativeName("AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT")]
    DebugTypeUndefinedBehavior = 6588,

    [NativeName("AL_DEBUG_TYPE_PORTABILITY_EXT")]
    DebugTypePortability = 6589,

    [NativeName("AL_DEBUG_TYPE_PERFORMANCE_EXT")]
    DebugTypePerformance = 6590,

    [NativeName("AL_DEBUG_TYPE_MARKER_EXT")]
    DebugTypeMarker = 6591,

    [NativeName("AL_DEBUG_TYPE_PUSH_GROUP_EXT")]
    DebugTypePushGroup = 6592,

    [NativeName("AL_DEBUG_TYPE_POP_GROUP_EXT")]
    DebugTypePopGroup = 6593,

    [NativeName("AL_DEBUG_TYPE_OTHER_EXT")]
    DebugTypeOther = 6594,
}
