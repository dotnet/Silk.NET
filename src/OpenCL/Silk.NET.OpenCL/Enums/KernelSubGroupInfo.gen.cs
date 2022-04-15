// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_kernel_sub_group_info")]
    public enum KernelSubGroupInfo : int
    {
        [NativeName("Name", "CL_KERNEL_MAX_NUM_SUB_GROUPS")]
        KernelMaxNumSubGroups = 0x11B9,
        [NativeName("Name", "CL_KERNEL_COMPILE_NUM_SUB_GROUPS")]
        KernelCompileNumSubGroups = 0x11BA,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE")]
        KernelMaxSubGroupSizeForNdrange = 0x2033,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE")]
        KernelSubGroupCountForNdrange = 0x2034,
        [NativeName("Name", "CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT")]
        KernelLocalSizeForSubGroupCount = 0x11B8,
        [NativeName("Name", "CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR")]
        KernelMaxSubGroupSizeForNdrangeKhr = 0x2033,
        [NativeName("Name", "CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR")]
        KernelSubGroupCountForNdrangeKhr = 0x2034,
        [NativeName("Name", "CL_KERNEL_COMPILE_SUB_GROUP_SIZE_INTEL")]
        KernelCompileSubGroupSizeIntel = 0x410A,
    }
}
