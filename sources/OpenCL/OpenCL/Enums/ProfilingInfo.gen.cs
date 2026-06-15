// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_profiling_info")]
public enum ProfilingInfo : uint
{
    [NativeName("CL_PROFILING_COMMAND_QUEUED")]
    Queued = 4736,

    [NativeName("CL_PROFILING_COMMAND_SUBMIT")]
    Submit = 4737,

    [NativeName("CL_PROFILING_COMMAND_START")]
    Start = 4738,

    [NativeName("CL_PROFILING_COMMAND_END")]
    End = 4739,

    [NativeName("CL_PROFILING_COMMAND_COMPLETE")]
    Complete = 4740,
}
