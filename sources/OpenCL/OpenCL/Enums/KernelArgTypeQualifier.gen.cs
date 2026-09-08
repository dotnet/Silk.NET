// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_kernel_arg_type_qualifier")]
[Flags]
public enum KernelArgTypeQualifier : ulong
{
    [NativeName("CL_KERNEL_ARG_TYPE_NONE")]
    None = 0x0,

    [NativeName("CL_KERNEL_ARG_TYPE_CONST")]
    Const = 0x1,

    [NativeName("CL_KERNEL_ARG_TYPE_RESTRICT")]
    Restrict = 0x2,

    [NativeName("CL_KERNEL_ARG_TYPE_VOLATILE")]
    Volatile = 0x4,

    [NativeName("CL_KERNEL_ARG_TYPE_PIPE")]
    Pipe = 0x8,
}
