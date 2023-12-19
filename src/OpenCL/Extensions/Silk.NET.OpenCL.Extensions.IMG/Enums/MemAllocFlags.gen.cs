// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [System.Flags]
    [NativeName("Name", "cl_mem_alloc_flags_img")]
    public enum MemAllocFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_MEM_ALLOC_RELAX_REQUIREMENTS_IMG")]
        RelaxRequirements = 0x1,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_WRITE_COMBINE_IMG")]
        GpuWriteCombine = 0x2,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_CACHED_IMG")]
        GpuCached = 0x4,
        [NativeName("Name", "CL_MEM_ALLOC_CPU_LOCAL_IMG")]
        CpuLocal = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_LOCAL_IMG")]
        GpuLocal = 0x10,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_PRIVATE_IMG")]
        GpuPrivate = 0x20,
    }
}
