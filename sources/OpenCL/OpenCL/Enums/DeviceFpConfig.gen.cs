// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_fp_config")]
[Flags]
public enum DeviceFpConfig : ulong
{
    None = 0x0,

    [NativeName("CL_FP_DENORM")]
    Denorm = 0x1,

    [NativeName("CL_FP_INF_NAN")]
    InfNan = 0x2,

    [NativeName("CL_FP_ROUND_TO_NEAREST")]
    RoundToNearest = 0x4,

    [NativeName("CL_FP_ROUND_TO_ZERO")]
    RoundToZero = 0x8,

    [NativeName("CL_FP_ROUND_TO_INF")]
    RoundToInf = 0x10,

    [NativeName("CL_FP_FMA")]
    Fma = 0x20,

    [NativeName("CL_FP_SOFT_FLOAT")]
    SoftFloat = 0x40,

    [NativeName("CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT")]
    CorrectlyRoundedDivideSqrt = 0x80,
}
