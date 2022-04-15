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
        KernelFunctionName = 0x1190,
        [NativeName("Name", "CL_KERNEL_NUM_ARGS")]
        KernelNumArgs = 0x1191,
        [NativeName("Name", "CL_KERNEL_REFERENCE_COUNT")]
        KernelReferenceCount = 0x1192,
        [NativeName("Name", "CL_KERNEL_CONTEXT")]
        KernelContext = 0x1193,
        [NativeName("Name", "CL_KERNEL_PROGRAM")]
        KernelProgram = 0x1194,
        [NativeName("Name", "CL_KERNEL_ATTRIBUTES")]
        KernelAttributes = 0x1195,
    }
}
