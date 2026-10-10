// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_kernel_arg_access_qualifier")]
public enum KernelArgAccessQualifier : uint
{
    [NativeName("CL_KERNEL_ARG_ACCESS_READ_ONLY")]
    ReadOnly = 4512,

    [NativeName("CL_KERNEL_ARG_ACCESS_WRITE_ONLY")]
    WriteOnly = 4513,

    [NativeName("CL_KERNEL_ARG_ACCESS_READ_WRITE")]
    ReadWrite = 4514,

    [NativeName("CL_KERNEL_ARG_ACCESS_NONE")]
    None = 4515,
}
