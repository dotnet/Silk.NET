// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_kernel_exec_info")]
    public enum KernelExecInfo : int
    {
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_PTRS")]
        KernelExecInfoSvmPtrs = 0x11B6,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM")]
        KernelExecInfoSvmFineGrainSystem = 0x11B7,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_HOST_ACCESS_INTEL")]
        KernelExecInfoIndirectHostAccessIntel = 0x4200,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_DEVICE_ACCESS_INTEL")]
        KernelExecInfoIndirectDeviceAccessIntel = 0x4201,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_INDIRECT_SHARED_ACCESS_INTEL")]
        KernelExecInfoIndirectSharedAccessIntel = 0x4202,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_USM_PTRS_INTEL")]
        KernelExecInfoUsmPtrsIntel = 0x4203,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_ARM")]
        KernelExecInfoWorkgroupBatchSizeArm = 0x41E5,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
        KernelExecInfoWorkgroupBatchSizeModifierArm = 0x41E6,
    }
}
