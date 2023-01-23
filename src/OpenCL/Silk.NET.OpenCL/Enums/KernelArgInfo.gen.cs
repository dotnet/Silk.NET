// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_kernel_arg_info")]
    public enum KernelArgInfo : int
    {
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_QUALIFIER")]
        AddressQualifier = 0x1196,
        [NativeName("Name", "CL_KERNEL_ARG_ACCESS_QUALIFIER")]
        AccessQualifier = 0x1197,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_NAME")]
        TypeName = 0x1198,
        [NativeName("Name", "CL_KERNEL_ARG_TYPE_QUALIFIER")]
        TypeQualifier = 0x1199,
        [NativeName("Name", "CL_KERNEL_ARG_NAME")]
        Name = 0x119A,
    }
}
