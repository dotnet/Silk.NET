// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_kernel_arg_address_qualifier")]
    public enum KernelArgAddressQualifier : int
    {
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_GLOBAL")]
        Global = 0x119B,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_LOCAL")]
        Local = 0x119C,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_CONSTANT")]
        Constant = 0x119D,
        [NativeName("Name", "CL_KERNEL_ARG_ADDRESS_PRIVATE")]
        Private = 0x119E,
    }
}
