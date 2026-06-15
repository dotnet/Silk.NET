// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_kernel_arg_info")]
public enum KernelArgInfo : uint
{
    [NativeName("CL_KERNEL_ARG_ADDRESS_QUALIFIER")]
    AddressQualifier = 4502,

    [NativeName("CL_KERNEL_ARG_ACCESS_QUALIFIER")]
    AccessQualifier = 4503,

    [NativeName("CL_KERNEL_ARG_TYPE_NAME")]
    TypeName = 4504,

    [NativeName("CL_KERNEL_ARG_TYPE_QUALIFIER")]
    TypeQualifier = 4505,

    [NativeName("CL_KERNEL_ARG_NAME")]
    Name = 4506,
}
