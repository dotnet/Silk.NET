// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mutable_dispatch_fields_khr")]
[Flags]
public enum MutableDispatchFieldsKHR : ulong
{
    None = 0x0,

    [NativeName("CL_MUTABLE_DISPATCH_GLOBAL_OFFSET_KHR")]
    GlobalOffset = 0x1,

    [NativeName("CL_MUTABLE_DISPATCH_GLOBAL_SIZE_KHR")]
    GlobalSize = 0x2,

    [NativeName("CL_MUTABLE_DISPATCH_LOCAL_SIZE_KHR")]
    LocalSize = 0x4,

    [NativeName("CL_MUTABLE_DISPATCH_ARGUMENTS_KHR")]
    Arguments = 0x8,

    [NativeName("CL_MUTABLE_DISPATCH_EXEC_INFO_KHR")]
    ExecInfo = 0x10,
}
