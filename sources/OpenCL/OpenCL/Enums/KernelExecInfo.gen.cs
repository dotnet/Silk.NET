// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_kernel_exec_info")]
public enum KernelExecInfo : uint
{
    [NativeName("CL_KERNEL_EXEC_INFO_SVM_PTRS")]
    SvmPtrs = 4534,

    [NativeName("CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM")]
    SvmFineGrainSystem = 4535,

    [NativeName("CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_ARM")]
    WorkgroupBatchSizeARM = 16869,

    [NativeName("CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
    WorkgroupBatchSizeModifierARM = 16870,

    [NativeName("CL_KERNEL_EXEC_INFO_WARP_COUNT_LIMIT_ARM")]
    WarpCountLimitARM = 16872,

    [NativeName("CL_KERNEL_EXEC_INFO_COMPUTE_UNIT_MAX_QUEUED_BATCHES_ARM")]
    ComputeUnitMaxQueuedBatchesARM = 16881,

    [NativeName("CL_KERNEL_EXEC_INFO_INDIRECT_HOST_ACCESS_INTEL")]
    IndirectHostAccessINTEL = 16896,

    [NativeName("CL_KERNEL_EXEC_INFO_INDIRECT_DEVICE_ACCESS_INTEL")]
    IndirectDeviceAccessINTEL = 16897,

    [NativeName("CL_KERNEL_EXEC_INFO_INDIRECT_SHARED_ACCESS_INTEL")]
    IndirectSharedAccessINTEL = 16898,

    [NativeName("CL_KERNEL_EXEC_INFO_USM_PTRS_INTEL")]
    UsmPtrsINTEL = 16899,

    [NativeName("CL_KERNEL_EXEC_INFO_DEVICE_PTRS_EXT")]
    DevicePtrsEXT = 20482,
}
