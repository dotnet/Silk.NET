// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum DebugType
{
    DontCare = 0x1100,
    DebugTypeError = 0x824C,
    DebugTypeDeprecatedBehavior = 0x824D,
    DebugTypeUndefinedBehavior = 0x824E,
    DebugTypePortability = 0x824F,
    DebugTypePerformance = 0x8250,
    DebugTypeOther = 0x8251,
    DebugTypeMarker = 0x8268,
    DebugTypePushGroup = 0x8269,
    DebugTypePopGroup = 0x826A
}
