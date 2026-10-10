// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_kernel_work_group_info")]
public enum KernelWorkGroupInfo : uint
{
    [NativeName("CL_KERNEL_WORK_GROUP_SIZE")]
    WorkGroupSize = 4528,

    [NativeName("CL_KERNEL_COMPILE_WORK_GROUP_SIZE")]
    CompileWorkGroupSize = 4529,

    [NativeName("CL_KERNEL_LOCAL_MEM_SIZE")]
    LocalMemSize = 4530,

    [NativeName("CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE")]
    PreferredWorkGroupSizeMultiple = 4531,

    [NativeName("CL_KERNEL_PRIVATE_MEM_SIZE")]
    PrivateMemSize = 4532,

    [NativeName("CL_KERNEL_GLOBAL_WORK_SIZE")]
    GlobalWorkSize = 4533,

    [NativeName("CL_KERNEL_SPILL_MEM_SIZE_INTEL")]
    SpillMemSizeINTEL = 16649,

    [NativeName("CL_KERNEL_ALLOCATIONS_INFO_INTEL")]
    AllocationsInfoINTEL = 16986,
}
