// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_program_build_info")]
public enum ProgramBuildInfo : uint
{
    [NativeName("CL_PROGRAM_BUILD_STATUS")]
    BuildStatus = 4481,

    [NativeName("CL_PROGRAM_BUILD_OPTIONS")]
    BuildOptions = 4482,

    [NativeName("CL_PROGRAM_BUILD_LOG")]
    BuildLog = 4483,

    [NativeName("CL_PROGRAM_BINARY_TYPE")]
    BinaryType = 4484,

    [NativeName("CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE")]
    BuildGlobalVariableTotalSize = 4485,
}
