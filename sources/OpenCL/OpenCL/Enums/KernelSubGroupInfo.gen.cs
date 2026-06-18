// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_kernel_sub_group_info")]
public enum KernelSubGroupInfo : uint
{
    [NativeName("CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE")]
    MaxSubGroupSizeForNdrange = 8243,

    [NativeName("CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE")]
    SubGroupCountForNdrange = 8244,

    [NativeName("CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT")]
    LocalSizeForSubGroupCount = 4536,

    [NativeName("CL_KERNEL_MAX_NUM_SUB_GROUPS")]
    MaxNumSubGroups = 4537,

    [NativeName("CL_KERNEL_COMPILE_NUM_SUB_GROUPS")]
    CompileNumSubGroups = 4538,

    [NativeName("CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR")]
    MaxSubGroupSizeForNdrangeKHR = 8243,

    [NativeName("CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR")]
    SubGroupCountForNdrangeKHR = 8244,

    [NativeName("CL_KERNEL_COMPILE_SUB_GROUP_SIZE_INTEL")]
    CompileSubGroupSizeINTEL = 16650,
}
