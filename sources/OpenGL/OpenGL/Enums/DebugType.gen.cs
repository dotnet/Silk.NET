// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum DebugType : uint
{
    DontCare = unchecked((uint)0x1100),
    DebugTypeError = unchecked((uint)0x824C),
    DebugTypeDeprecatedBehavior = unchecked((uint)0x824D),
    DebugTypeUndefinedBehavior = unchecked((uint)0x824E),
    DebugTypePortability = unchecked((uint)0x824F),
    DebugTypePerformance = unchecked((uint)0x8250),
    DebugTypeOther = unchecked((uint)0x8251),
    DebugTypeMarker = unchecked((uint)0x8268),
    DebugTypePushGroup = unchecked((uint)0x8269),
    DebugTypePopGroup = unchecked((uint)0x826A),
}
