// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_mem_flags")]
    public enum MemFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_MEM_READ_WRITE")]
        ReadWrite = 0x1,
        [NativeName("Name", "CL_MEM_WRITE_ONLY")]
        WriteOnly = 0x2,
        [NativeName("Name", "CL_MEM_READ_ONLY")]
        ReadOnly = 0x4,
        [NativeName("Name", "CL_MEM_USE_HOST_PTR")]
        UseHostPtr = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_HOST_PTR")]
        AllocHostPtr = 0x10,
        [NativeName("Name", "CL_MEM_COPY_HOST_PTR")]
        CopyHostPtr = 0x20,
        [NativeName("Name", "CL_MEM_HOST_WRITE_ONLY")]
        HostWriteOnly = 0x80,
        [NativeName("Name", "CL_MEM_HOST_READ_ONLY")]
        HostReadOnly = 0x100,
        [NativeName("Name", "CL_MEM_HOST_NO_ACCESS")]
        HostNoAccess = 0x200,
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER")]
        SvmFineGrainBuffer = 0x400,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS")]
        SvmAtomics = 0x800,
        [NativeName("Name", "CL_MEM_KERNEL_READ_AND_WRITE")]
        KernelReadAndWrite = 0x1000,
        [NativeName("Name", "CL_MEM_EXT_HOST_PTR_QCOM")]
        ExtHostPtrQCom = 0x20000000,
        [NativeName("Name", "CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG")]
        UseUncachedCpuMemoryImg = 0x4000000,
        [NativeName("Name", "CL_MEM_USE_CACHED_CPU_MEMORY_IMG")]
        UseCachedCpuMemoryImg = 0x8000000,
        [NativeName("Name", "CL_MEM_USE_GRALLOC_PTR_IMG")]
        UseGrallocPtrImg = 0x10000000,
        [NativeName("Name", "CL_MEM_NO_ACCESS_INTEL")]
        NoAccessIntel = 0x1000000,
        [NativeName("Name", "CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL")]
        AccessFlagsUnrestrictedIntel = 0x2000000,
        [NativeName("Name", "CL_MEM_FORCE_HOST_MEMORY_INTEL")]
        ForceHostMemoryIntel = 0x100000,
        [NativeName("Name", "CL_MEM_PROTECTED_ALLOC_ARM")]
        ProtectedAllocArm = 0x1000000000,
        [NativeName("Name", "CL_MEM_IMMUTABLE_EXT")]
        ImmutableExt = 0x40,
    }
}
