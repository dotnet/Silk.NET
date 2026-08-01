// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_program_binary_type")]
public enum ProgramBinaryType : uint
{
    [NativeName("CL_PROGRAM_BINARY_TYPE_NONE")]
    None = 0,

    [NativeName("CL_PROGRAM_BINARY_TYPE_COMPILED_OBJECT")]
    CompiledObject = 1,

    [NativeName("CL_PROGRAM_BINARY_TYPE_LIBRARY")]
    Library = 2,

    [NativeName("CL_PROGRAM_BINARY_TYPE_EXECUTABLE")]
    Executable = 4,

    [NativeName("CL_PROGRAM_BINARY_TYPE_INTERMEDIATE")]
    Intermediate = 16609,
}
