// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_flags")]
    public enum MemFlags : ulong
    {
        [NativeName("Name", "CL_MEM_READ_WRITE")]
        MemReadWrite = 0x1,
        [NativeName("Name", "CL_MEM_WRITE_ONLY")]
        MemWriteOnly = 0x2,
        [NativeName("Name", "CL_MEM_READ_ONLY")]
        MemReadOnly = 0x4,
        [NativeName("Name", "CL_MEM_USE_HOST_PTR")]
        MemUseHostPtr = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_HOST_PTR")]
        MemAllocHostPtr = 0x10,
        [NativeName("Name", "CL_MEM_COPY_HOST_PTR")]
        MemCopyHostPtr = 0x20,
        [NativeName("Name", "CL_MEM_HOST_WRITE_ONLY")]
        MemHostWriteOnly = 0x80,
        [NativeName("Name", "CL_MEM_HOST_READ_ONLY")]
        MemHostReadOnly = 0x100,
        [NativeName("Name", "CL_MEM_HOST_NO_ACCESS")]
        MemHostNoAccess = 0x200,
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER")]
        MemSvmFineGrainBuffer = 0x400,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS")]
        MemSvmAtomics = 0x800,
        [NativeName("Name", "CL_MEM_KERNEL_READ_AND_WRITE")]
        MemKernelReadAndWrite = 0x1000,
        [NativeName("Name", "CL_MEM_FORCE_HOST_MEMORY_INTEL")]
        MemForceHostMemoryIntel = 0x100000,
        [NativeName("Name", "CL_MEM_RESERVED21_INTEL")]
        MemReserved21Intel = 0x200000,
        [NativeName("Name", "CL_MEM_RESERVED22_INTEL")]
        MemReserved22Intel = 0x400000,
        [NativeName("Name", "CL_MEM_NO_ACCESS_INTEL")]
        MemNoAccessIntel = 0x1000000,
        [NativeName("Name", "CL_MEM_ACCESS_FLAGS_UNRESTRICTED_INTEL")]
        MemAccessFlagsUnrestrictedIntel = 0x2000000,
        [NativeName("Name", "CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG")]
        MemUseUncachedCpuMemoryImg = 0x4000000,
        [NativeName("Name", "CL_MEM_USE_CACHED_CPU_MEMORY_IMG")]
        MemUseCachedCpuMemoryImg = 0x8000000,
        [NativeName("Name", "CL_MEM_USE_GRALLOC_PTR_IMG")]
        MemUseGrallocPtrImg = 0x10000000,
        [NativeName("Name", "CL_MEM_EXT_HOST_PTR_QCOM")]
        MemExtHostPtrQCom = 0x20000000,
        [NativeName("Name", "CL_MEM_RESERVED0_ARM")]
        MemReserved0Arm = 0x100000000,
        [NativeName("Name", "CL_MEM_RESERVED1_ARM")]
        MemReserved1Arm = 0x200000000,
        [NativeName("Name", "CL_MEM_RESERVED2_ARM")]
        MemReserved2Arm = 0x400000000,
        [NativeName("Name", "CL_MEM_RESERVED3_ARM")]
        MemReserved3Arm = 0x800000000,
        [NativeName("Name", "CL_MEM_PROTECTED_ALLOC_ARM")]
        MemProtectedAllocArm = 0x1000000000,
        [NativeName("Name", "CL_MEM_RESERVED0_QCOM")]
        MemReserved0QCom = 0x2000000000,
        [NativeName("Name", "CL_MEM_RESERVED1_QCOM")]
        MemReserved1QCom = 0x4000000000,
        [NativeName("Name", "CL_MEM_RESERVED2_QCOM")]
        MemReserved2QCom = 0x8000000000,
        [NativeName("Name", "CL_MEM_RESERVED3_QCOM")]
        MemReserved3QCom = 0x10000000000,
    }
}
