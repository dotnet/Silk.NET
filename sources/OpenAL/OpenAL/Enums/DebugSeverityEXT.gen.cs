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
public enum DebugSeverityEXT : uint
{
    DontCare = unchecked((uint)0x0002),
    DebugSeverityHigh = unchecked((uint)0x19C3),
    DebugSeverityMedium = unchecked((uint)0x19C4),
    DebugSeverityLow = unchecked((uint)0x19C5),
    DebugSeverityNotification = unchecked((uint)0x19C6),
}
