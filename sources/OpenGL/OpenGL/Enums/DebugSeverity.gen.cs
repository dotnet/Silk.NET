// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DebugSeverity")]
[Transformed]
public enum DebugSeverity : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = unchecked((uint)0x1100),

    [NativeName("GL_DEBUG_SEVERITY_HIGH")]
    DebugSeverityHigh = unchecked((uint)0x9146),

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM")]
    DebugSeverityMedium = unchecked((uint)0x9147),

    [NativeName("GL_DEBUG_SEVERITY_LOW")]
    DebugSeverityLow = unchecked((uint)0x9148),

    [NativeName("GL_DEBUG_SEVERITY_NOTIFICATION")]
    DebugSeverityNotification = unchecked((uint)0x826B),
}
