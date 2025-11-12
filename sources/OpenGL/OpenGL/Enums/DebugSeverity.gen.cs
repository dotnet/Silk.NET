// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum DebugSeverity : uint
{
    DontCare = unchecked((uint)0x1100),
    DebugSeverityHigh = unchecked((uint)0x9146),
    DebugSeverityMedium = unchecked((uint)0x9147),
    DebugSeverityLow = unchecked((uint)0x9148),
    DebugSeverityNotification = unchecked((uint)0x826B),
}
