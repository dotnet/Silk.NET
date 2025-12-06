// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DebugSeverity")]
public enum DebugSeverity : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = 4352,

    [NativeName("GL_DEBUG_SEVERITY_HIGH")]
    DebugSeverityHigh = 37190,

    [NativeName("GL_DEBUG_SEVERITY_MEDIUM")]
    DebugSeverityMedium = 37191,

    [NativeName("GL_DEBUG_SEVERITY_LOW")]
    DebugSeverityLow = 37192,

    [NativeName("GL_DEBUG_SEVERITY_NOTIFICATION")]
    DebugSeverityNotification = 33387,
}
