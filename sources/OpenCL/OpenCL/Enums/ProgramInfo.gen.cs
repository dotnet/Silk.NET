// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_program_info")]
public enum ProgramInfo : uint
{
    [NativeName("CL_PROGRAM_REFERENCE_COUNT")]
    ReferenceCount = 4448,

    [NativeName("CL_PROGRAM_CONTEXT")]
    Context = 4449,

    [NativeName("CL_PROGRAM_NUM_DEVICES")]
    NumDevices = 4450,

    [NativeName("CL_PROGRAM_DEVICES")]
    Devices = 4451,

    [NativeName("CL_PROGRAM_SOURCE")]
    Source = 4452,

    [NativeName("CL_PROGRAM_BINARY_SIZES")]
    BinarySizes = 4453,

    [NativeName("CL_PROGRAM_BINARIES")]
    Binaries = 4454,

    [NativeName("CL_PROGRAM_NUM_KERNELS")]
    NumKernels = 4455,

    [NativeName("CL_PROGRAM_KERNEL_NAMES")]
    KernelNames = 4456,

    [NativeName("CL_PROGRAM_IL")]
    Il = 4457,

    [NativeName("CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT")]
    ScopeGlobalCtorsPresent = 4458,

    [NativeName("CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT")]
    ScopeGlobalDtorsPresent = 4459,
}
