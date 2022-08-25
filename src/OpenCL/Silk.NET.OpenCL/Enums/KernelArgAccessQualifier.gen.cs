// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_kernel_arg_access_qualifier")]
    public enum KernelArgAccessQualifier : int
    {
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_ONLY")]
        ReadOnly = 0x11A0,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_WRITE_ONLY")]
        WriteOnly = 0x11A1,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_READ_WRITE")]
        ReadWrite = 0x11A2,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_NONE")]
        None = 0x11A3,
    }
}
