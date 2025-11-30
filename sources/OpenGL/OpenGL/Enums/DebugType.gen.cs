// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DebugType")]
[Transformed]
public enum DebugType : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = unchecked((uint)0x1100),

    [NativeName("GL_DEBUG_TYPE_ERROR")]
    DebugTypeError = unchecked((uint)0x824C),

    [NativeName("GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR")]
    DebugTypeDeprecatedBehavior = unchecked((uint)0x824D),

    [NativeName("GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR")]
    DebugTypeUndefinedBehavior = unchecked((uint)0x824E),

    [NativeName("GL_DEBUG_TYPE_PORTABILITY")]
    DebugTypePortability = unchecked((uint)0x824F),

    [NativeName("GL_DEBUG_TYPE_PERFORMANCE")]
    DebugTypePerformance = unchecked((uint)0x8250),

    [NativeName("GL_DEBUG_TYPE_OTHER")]
    DebugTypeOther = unchecked((uint)0x8251),

    [NativeName("GL_DEBUG_TYPE_MARKER")]
    DebugTypeMarker = unchecked((uint)0x8268),

    [NativeName("GL_DEBUG_TYPE_PUSH_GROUP")]
    DebugTypePushGroup = unchecked((uint)0x8269),

    [NativeName("GL_DEBUG_TYPE_POP_GROUP")]
    DebugTypePopGroup = unchecked((uint)0x826A),
}
