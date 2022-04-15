// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_kernel_work_group_info")]
    public enum KernelWorkGroupInfo : int
    {
        [NativeName("Name", "CL_KERNEL_WORK_GROUP_SIZE")]
        KernelWorkGroupSize = 0x11B0,
        [NativeName("Name", "CL_KERNEL_COMPILE_WORK_GROUP_SIZE")]
        KernelCompileWorkGroupSize = 0x11B1,
        [NativeName("Name", "CL_KERNEL_LOCAL_MEM_SIZE")]
        KernelLocalMemSize = 0x11B2,
        [NativeName("Name", "CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
        KernelPreferredWorkGroupSizeMultiple = 0x11B3,
        [NativeName("Name", "CL_KERNEL_PRIVATE_MEM_SIZE")]
        KernelPrivateMemSize = 0x11B4,
        [NativeName("Name", "CL_KERNEL_GLOBAL_WORK_SIZE")]
        KernelGlobalWorkSize = 0x11B5,
        [NativeName("Name", "CL_KERNEL_SPILL_MEM_SIZE_INTEL")]
        KernelSpillMemSizeIntel = 0x4109,
    }
}
