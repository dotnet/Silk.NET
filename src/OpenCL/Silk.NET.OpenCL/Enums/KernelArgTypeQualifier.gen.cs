// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_kernel_arg_type_qualifier")]
    public enum KernelArgTypeQualifier : ulong
    {
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_CONST")]
        Const = 0x1,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_RESTRICT")]
        Restrict = 0x2,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_VOLATILE")]
        Volatile = 0x4,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_PIPE")]
        Pipe = 0x8,
    }
}
