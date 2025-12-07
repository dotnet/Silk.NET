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

[Transformed]
public enum DebugTypeEXT : uint
{
    DontCare = unchecked((uint)0x0002),
    DebugTypeError = unchecked((uint)0x19BA),
    DebugTypeDeprecatedBehavior = unchecked((uint)0x19BB),
    DebugTypeUndefinedBehavior = unchecked((uint)0x19BC),
    DebugTypePortability = unchecked((uint)0x19BD),
    DebugTypePerformance = unchecked((uint)0x19BE),
    DebugTypeMarker = unchecked((uint)0x19BF),
    DebugTypePushGroup = unchecked((uint)0x19C0),
    DebugTypePopGroup = unchecked((uint)0x19C1),
    DebugTypeOther = unchecked((uint)0x19C2),
}
