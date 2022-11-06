// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_kernel_info")]
    public enum KernelInfo : int
    {
        [NativeName("Name", "CL_KERNEL_FUNCTION_NAME")]
        FunctionName = 0x1190,
        [NativeName("Name", "CL_KERNEL_NUM_ARGS")]
        NumArgs = 0x1191,
        [NativeName("Name", "CL_KERNEL_REFERENCE_COUNT")]
        ReferenceCount = 0x1192,
        [NativeName("Name", "CL_KERNEL_CONTEXT")]
        Context = 0x1193,
        [NativeName("Name", "CL_KERNEL_PROGRAM")]
        Program = 0x1194,
        [NativeName("Name", "CL_KERNEL_ATTRIBUTES")]
        Attributes = 0x1195,
        [NativeName("Name", "CL_KERNEL_MAX_WARP_COUNT_ARM")]
        MaxWarpCountArm = 0x41E9,
    }
}
