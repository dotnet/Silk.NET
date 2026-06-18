// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_diagnostic_verbose_level_intel")]
[Flags]
public enum DiagnosticVerboseLevelINTEL : ulong
{
    None = 0x0,

    [NativeName("CL_CONTEXT_DIAGNOSTICS_LEVEL_ALL_INTEL")]
    All = 0xFF,

    [NativeName("CL_CONTEXT_DIAGNOSTICS_LEVEL_GOOD_INTEL")]
    Good = 0x1,

    [NativeName("CL_CONTEXT_DIAGNOSTICS_LEVEL_BAD_INTEL")]
    Bad = 0x2,

    [NativeName("CL_CONTEXT_DIAGNOSTICS_LEVEL_NEUTRAL_INTEL")]
    Neutral = 0x4,
}
