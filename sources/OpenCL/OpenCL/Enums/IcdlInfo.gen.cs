// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_icdl_info")]
public enum IcdlInfo : uint
{
    [NativeName("CL_ICDL_OCL_VERSION")]
    OclVersion = 1,

    [NativeName("CL_ICDL_VERSION")]
    Version = 2,

    [NativeName("CL_ICDL_NAME")]
    Name = 3,

    [NativeName("CL_ICDL_VENDOR")]
    Vendor = 4,
}
