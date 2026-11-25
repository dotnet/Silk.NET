// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_Anonymous1_e__Union")]
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct IcdDispatchAnonymous1
{
    [NativeName("clGetPlatformIDs")]
    [FieldOffset(0)]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchAnonymous1GetPlatformIDs ClGetPlatformIDs;

    [NativeName("clGetPlatformIDs_icd2_tag")]
    [FieldOffset(0)]
    public nint ClGetPlatformIDsIcd2Tag;
}
