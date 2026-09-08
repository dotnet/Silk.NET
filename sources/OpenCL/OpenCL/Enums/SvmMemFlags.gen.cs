// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_svm_mem_flags")]
[Flags]
public enum SvmMemFlags : ulong
{
    None = 0x0,

    [NativeName("CL_MEM_READ_WRITE")]
    ReadWrite = 0x1,

    [NativeName("CL_MEM_WRITE_ONLY")]
    WriteOnly = 0x2,

    [NativeName("CL_MEM_READ_ONLY")]
    ReadOnly = 0x4,

    [NativeName("CL_MEM_USE_HOST_PTR")]
    UseHostPtr = 0x8,

    [NativeName("CL_MEM_ALLOC_HOST_PTR")]
    AllocHostPtr = 0x10,

    [NativeName("CL_MEM_COPY_HOST_PTR")]
    CopyHostPtr = 0x20,

    [NativeName("CL_MEM_HOST_WRITE_ONLY")]
    HostWriteOnly = 0x80,

    [NativeName("CL_MEM_HOST_READ_ONLY")]
    HostReadOnly = 0x100,

    [NativeName("CL_MEM_HOST_NO_ACCESS")]
    HostNoAccess = 0x200,

    [NativeName("CL_MEM_SVM_FINE_GRAIN_BUFFER")]
    SvmFineGrainBuffer = 0x400,

    [NativeName("CL_MEM_SVM_ATOMICS")]
    SvmAtomics = 0x800,

    [NativeName("CL_MEM_KERNEL_READ_AND_WRITE")]
    KernelReadAndWrite = 0x1000,
}
