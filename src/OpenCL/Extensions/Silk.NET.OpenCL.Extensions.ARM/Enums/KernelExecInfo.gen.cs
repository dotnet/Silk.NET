// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [NativeName("Name", "cl_kernel_exec_info_arm")]
    public enum KernelExecInfo : int
    {
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_PTRS_ARM")]
        Ptrs = 0x40B8,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM_ARM")]
        FineGrainSystem = 0x40B9,
    }
}
