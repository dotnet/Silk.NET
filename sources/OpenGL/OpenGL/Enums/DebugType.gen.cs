// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DebugType")]
public enum DebugType : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = 4352,

    [NativeName("GL_DEBUG_TYPE_ERROR")]
    DebugTypeError = 33356,

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR")]
    DebugTypeDeprecatedBehavior = 33357,

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR")]
    DebugTypeUndefinedBehavior = 33358,

    [NativeName("GL_DEBUG_TYPE_PORTABILITY")]
    DebugTypePortability = 33359,

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE")]
    DebugTypePerformance = 33360,

    [NativeName("GL_DEBUG_TYPE_OTHER")]
    DebugTypeOther = 33361,

    [NativeName("GL_DEBUG_TYPE_MARKER")]
    DebugTypeMarker = 33384,

    [NativeName("GL_DEBUG_TYPE_PUSH_GROUP")]
    DebugTypePushGroup = 33385,

    [NativeName("GL_DEBUG_TYPE_POP_GROUP")]
    DebugTypePopGroup = 33386,
}
