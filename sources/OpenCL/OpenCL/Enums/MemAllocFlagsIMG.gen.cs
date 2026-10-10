// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mem_alloc_flags_img")]
[Flags]
public enum MemAllocFlagsIMG : ulong
{
    None = 0x0,

    [NativeName("CL_MEM_ALLOC_RELAX_REQUIREMENTS_IMG")]
    RelaxRequirements = 0x1,

    [NativeName("CL_MEM_ALLOC_GPU_WRITE_COMBINE_IMG")]
    GpuWriteCombine = 0x2,

    [NativeName("CL_MEM_ALLOC_GPU_CACHED_IMG")]
    GpuCached = 0x4,

    [NativeName("CL_MEM_ALLOC_CPU_LOCAL_IMG")]
    CpuLocal = 0x8,

    [NativeName("CL_MEM_ALLOC_GPU_LOCAL_IMG")]
    GpuLocal = 0x10,

    [NativeName("CL_MEM_ALLOC_GPU_PRIVATE_IMG")]
    GpuPrivate = 0x20,
}
