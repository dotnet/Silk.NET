// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_kernel_info")]
public enum KernelInfo : uint
{
    [NativeName("CL_KERNEL_FUNCTION_NAME")]
    FunctionName = 4496,

    [NativeName("CL_KERNEL_NUM_ARGS")]
    NumArgs = 4497,

    [NativeName("CL_KERNEL_REFERENCE_COUNT")]
    ReferenceCount = 4498,

    [NativeName("CL_KERNEL_CONTEXT")]
    ContEXT = 4499,

    [NativeName("CL_KERNEL_PROGRAM")]
    Program = 4500,

    [NativeName("CL_KERNEL_ATTRIBUTES")]
    Attributes = 4501,
}
