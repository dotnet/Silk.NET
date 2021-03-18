// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "DebugType")]
    public enum DebugType : int
    {
        [NativeName("Name", "GL_DONT_CARE")]
        DontCare = 0x1100,
        [NativeName("Name", "GL_DEBUG_TYPE_ERROR")]
        DebugTypeError = 0x824C,
        [NativeName("Name", "GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR")]
        DebugTypeDeprecatedBehavior = 0x824D,
        [NativeName("Name", "GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR")]
        DebugTypeUndefinedBehavior = 0x824E,
        [NativeName("Name", "GL_DEBUG_TYPE_PORTABILITY")]
        DebugTypePortability = 0x824F,
        [NativeName("Name", "GL_DEBUG_TYPE_PERFORMANCE")]
        DebugTypePerformance = 0x8250,
        [NativeName("Name", "GL_DEBUG_TYPE_OTHER")]
        DebugTypeOther = 0x8251,
        [NativeName("Name", "GL_DEBUG_TYPE_MARKER")]
        DebugTypeMarker = 0x8268,
        [NativeName("Name", "GL_DEBUG_TYPE_PUSH_GROUP")]
        DebugTypePushGroup = 0x8269,
        [NativeName("Name", "GL_DEBUG_TYPE_POP_GROUP")]
        DebugTypePopGroup = 0x826A,
    }
}
